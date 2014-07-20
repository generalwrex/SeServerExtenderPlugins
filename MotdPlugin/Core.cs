using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

using SEModAPIExtensions.API;
using SEModAPIExtensions.API.Plugin;
using SEModAPIExtensions.API.Plugin.Events;

using SEModAPIInternal.API;
using SEModAPIInternal.API.Common;
using SEModAPIInternal.API.Entity;
using SEModAPIInternal.API.Entity.Sector;
using SEModAPIInternal.API.Entity.Sector.SectorObject;
using SEModAPIInternal.API.Entity.Sector.SectorObject.CubeGrid;
using SEModAPIInternal.API.Entity.Sector.SectorObject.CubeGrid.CubeBlock;
using SEModAPIInternal.API.Server;

using SEModAPI.API;
using SEModAPI.API.Definitions;
using SEModAPI.Support;




namespace MotdPlugin
{
    public class Core : PluginBase, IChatEventHandler
    {

        #region "Attributes"

		private static MotdPluginConfigForm m_pluginConfigForm;

		private static MotdPluginData m_definition;

		private static FileIODefinitions m_fileIODefinitions;

		private static Adverts m_adverts;


        private static string m_dataFile;
        private static string m_assemblyFolder;

        private static List<string> m_motdLines;
		private static List<string> m_motdParsedLines;

        private static string m_motdTitle;

        private static string m_advertsString;
        private static string[] m_seperateAdverts;

        private static bool m_isDebugging;

        private static bool m_motdActive;
        private static bool m_advertsActive;


        private Dictionary<Timer, string> m_timers = new Dictionary<Timer, string>();

        private List<string> AdvertList = new List<string>();

        #endregion

        #region "Constructors and Initializers"

		public Core(MotdPluginData definition)
		{
			m_definition = definition;

			// Default settings if the file doesn't exist.
			m_pluginConfigForm.MotdActive = false;
            m_pluginConfigForm.AdvertsActive = false;


            // Get the current path of the DLL.
            m_assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            m_dataFile = Path.Combine(m_assemblyFolder, "MotdPlugin_Settings.xml");

            try
            {	
				m_fileIODefinitions.Load();
            }
            catch (Exception ex)
            {
				Console.WriteLine("Motd Plugin - Error: " + ex.ToString());
            }

        }

        public override void Init()
        {
            Console.WriteLine("Motd Plugin '" + Id.ToString() + "' initialized!");
            Console.WriteLine("Motd Plugin - Loading Data");
			m_fileIODefinitions.Load();
            m_isDebugging = SandboxGameAssemblyWrapper.IsDebugging;
        }

        #endregion

        #region "Properties"

		public bool MotdChanged
		{
			get;
			private set;
		}

		public bool AdvertsChanged
		{
			get;
			private set;
		}

        public bool MotdActive
        {
			get { return m_definition.MotdActive; }
            set
            {
				m_definition.MotdActive = value;
				MotdChanged = true;
            }
        }

        public string MotdTitle
        {
            get { return m_definition.MotdTitle; }
            set
            {
                m_definition.MotdTitle = value;
                MotdChanged = true;
            }
        }

        public List<string> MotdLines
        {
            get { return m_definition.MotdLines; }
            set
            {
                m_definition.MotdLines = value;
                MotdChanged = true;
            }
        }

        public bool AdvertsActive
        {
            get { return m_definition.AdvertsActive; }
            set
            {
                m_definition.AdvertsActive = value;
                AdvertsChanged = true;
            }
        }

        public string Adverts
        {
            get { return m_advertsString; }
            set
            {
                m_advertsString = value;
                AdvertsChanged = true;
            }
        }

        #endregion

        #region "EventHandlers"

        public override void Update()
        {
            // Checks and sets the new Motd text.        
            if (MotdChanged && m_motdLines.Count() != 0 && m_motdTitle != "")
            {
				m_fileIODefinitions.Save();

                MotdChanged = false;
            }

            // Checks and sets the Adverts.
            if (AdvertsChanged && m_advertsString != "")
            {
                if (m_advertsActive)
                {
                    this.ClearAdvertTimers();
                    this.ParseAdverts();
                }
                else
                {
                    this.ClearAdvertTimers();
                }

                AdvertsChanged = false;
            }
        }

        // Called when a client says something in chat.
        public void OnChatReceived(ChatManager.ChatEvent client)
        {
            ulong id = client.sourceUserId;

            if (!m_motdActive)
                return;

            try
            {
                // If they said /motd                
                if (client.message.Substring(0, 5).Contains(("/motd")))
                {
                    ChatManager.Instance.SendPrivateChatMessage(id, m_motdTitle);

					//foreach(string line in ParseMotd())
					//{
					//	ChatManager.Instance.SendPrivateChatMessage(id, line);
					//}
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Motd Plugin - Error: " + ex.ToString());
            }
        }

        public void OnChatSent(ChatManager.ChatEvent events)
        {
        }

		// Called when the server is shutdown, or plugin is unloaded.
		public override void Shutdown()
		{
			m_fileIODefinitions.Save();
			this.ClearAdvertTimers();
		}

        #endregion

        #region "Methods"

        private void ClearAdvertTimers()
        {
            // Disable and Stop all timers in the Dictonary
            foreach (Timer timer in m_timers.Keys)
            {
                timer.Enabled = false;
                timer.Stop();
            }

            // Clear out the Dictionary and AdvertList list.
            m_timers.Clear();
        }
		/*
		public string ReplaceFormatting(string stringtoparse)
		{
			string parsedstring = "";

			parsedstring += stringtoparse.Replace("%time%", DateTime.Now.TimeOfDay.ToString());
			parsedstring += stringtoparse.Replace("%date%", DateTime.Today.Date.ToString());
			parsedstring += stringtoparse.Replace("%asteroidcount%",


			return parsedstring;
		}
		*/

        private void ParseAdverts()
        {
            try
            {
                if (m_isDebugging)
                    Console.WriteLine("Motd Plugin - Parsing Adverts");

                // Seperate the adverts at the semicolons.
                m_seperateAdverts = m_advertsString.Split(new string[] { ";;" }, StringSplitOptions.None);

				if (m_isDebugging)
					Console.WriteLine("Motd Plugin - Parsed {0} Adverts.", m_seperateAdverts.Count());

                // Add all the adverts to the AdvertList
                AdvertList.AddRange(m_seperateAdverts);

                if (m_advertsActive)
                {
                    // For each advert in the list;
                    // Create a timer, name it with the advert strings.
                    // When the time is up for each advert it prints to Chat.
                    AdvertList.ForEach(delegate(string advert)
                    {
	
                        string[] splitadverts = advert.Split(new string[] { "::" },
                            StringSplitOptions.None);

                        // Setup the timers.
                        Timer time = new Timer();
                        time.AutoReset = true;
                        time.Interval = 1000 * Int32.Parse(splitadverts.ElementAt(1));
                        m_timers.Add(time, splitadverts[0]);

                        time.Elapsed += delegate(object sender, System.Timers.ElapsedEventArgs eventArgs)
                        {
                            Timer t = (Timer)sender;
                            Console.WriteLine(m_timers[t]);
                            ChatManager.Instance.SendPublicChatMessage(m_timers[t]);
                        };

                        time.Enabled = true;
                        time.Start();
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Motd Plugin - Error: " + ex.ToString());
            }

        }

        #endregion
    }
}

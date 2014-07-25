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
    public class MotdPluginCore : PluginBase, IChatEventHandler
    {

        #region "Attributes"

		private static MotdPluginConfigForm m_pluginConfigForm;

		private static MotdPluginData m_motdPluginData;

		private static FileIODefinitions m_fileIODefinitions;

		private static Adverts m_adverts;


        private static string m_dataFile;
        private static string m_assemblyFolder;

        private static List<string> m_motdLines;
		private static List<string> m_motdParsedLines;

        private static string m_motdTitle;


        private static bool m_isDebugging;

        private Dictionary<Timer, string> m_timers = new Dictionary<Timer, string>();

        #endregion

        #region "Constructors and Initializers"

		public MotdPluginCore()
		{
            try
            {
				// Get the current path of the DLL.
				m_assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
				m_dataFile = Path.Combine(m_assemblyFolder, "MotdPlugin_Settings.xml");

				if (!File.Exists(m_dataFile))
				{

					m_motdPluginData.MotdActive = false;
					m_motdPluginData.MotdTitle = "[Message Of The Day - %date%%time12%";

					string[] m_defaultMotd = { "" };
					m_defaultMotd[0] = "Welcome to %servername%.";
					m_defaultMotd[1] = "Gamemode : %gamemode%. ";
					m_defaultMotd[2] = "World: %worldname%.";
					m_defaultMotd[3] = "Asteroids: %asteroidcount%";
					m_defaultMotd[4] = "Players: %playercount%";
					m_defaultMotd[5] = "";
					m_defaultMotd[6] = "You can Have up to 45 characters per line";
					m_defaultMotd[7] = "and 8 lines  because of the current limitation";

					m_motdPluginData.MotdLines.AddRange(m_defaultMotd);

					m_motdPluginData.AdvertsActive = false;

					m_adverts.AddAdvert("readmotd", "Use /motd to read the Message of the day!", 360, true);
					m_adverts.AddAdvert("welcome", "Welcome to the server! Its %time12% on %date%!", 360, true);

					m_motdPluginData.AdvertsList.AddRange(m_adverts.AdvertList);
				}
            }
            catch (Exception ex)
            {
				Console.WriteLine("Motd Plugin - Error: " + ex.ToString());
            }

			Console.WriteLine("Motd Plugin '" + Id.ToString() + "' initialized!");
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


		[Category("Motd Plugin")]
		[Description("Shows the Config Dialog")]
		[Browsable(true)]
		[ReadOnly(false)]
		public bool ShowConfig
		{
			get { return m_pluginConfigForm.Visible; }
			set { m_pluginConfigForm.Show(); }
		}


		public bool MotdChanged
		{
			get;
			private set;
		}

		public bool AdvertsChanged
		{
			get;
			set;
		}

        public bool MotdActive
        {
			get { return m_motdPluginData.MotdActive; }
            set
            {
				m_motdPluginData.MotdActive = value;
				MotdChanged = true;
            }
        }

        public string MotdTitle
        {
			get { return m_motdPluginData.MotdTitle; }
            set
            {
				m_motdPluginData.MotdTitle = value;
                MotdChanged = true;
            }
        }

        public List<string> MotdLines
        {
			get { return m_motdPluginData.MotdLines; }
            set
            {
				m_motdPluginData.MotdLines = value;
                MotdChanged = true;
            }
        }

        public bool AdvertsActive
        {
			get { return m_motdPluginData.AdvertsActive; }
            set
            {
				m_motdPluginData.AdvertsActive = value;
                AdvertsChanged = true;
            }
        }
			
        #endregion

        #region "EventHandlers"

        public override void Update()
        {
            // Checks and sets the new Motd text.        
            if (MotdChanged && m_motdLines.Count() != 0 && MotdTitle != "")
            {
				bool saved = m_fileIODefinitions.Save();
                MotdChanged = false;
            }

            // Checks and sets the Adverts.
            if (AdvertsChanged && Adverts.Instance.AdvertList.Count() != 0)
            {
                if (AdvertsActive)
                {
                    this.ParseAdverts();
					m_fileIODefinitions.Save();
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

            if (!MotdActive)
                return;

            try
            {
                // If they said /motd                
                if (client.message.Substring(0, 5).Contains(("/motd")))
                {
                    ChatManager.Instance.SendPrivateChatMessage(id, ReplaceFormatting(MotdTitle));

					foreach(string line in MotdLines)
					{
						ChatManager.Instance.SendPrivateChatMessage(id, ReplaceFormatting(line));
					}
                    
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
		
		private string ReplaceFormatting(string stringtoparse)
		{
			string parsedstring = "";

			parsedstring = stringtoparse.Replace("%time%", DateTime.Now.TimeOfDay.ToString());
			parsedstring = parsedstring.Replace("%date%", DateTime.Today.Date.ToString());


			return parsedstring;
		}

        private void ParseAdverts()
        {
            try
            {
                if (m_isDebugging)
                    Console.WriteLine("Motd Plugin - Parsing Adverts");
        
				if (m_isDebugging)
					Console.WriteLine("Motd Plugin - Parsed {0} Adverts.", Adverts.Instance.AdvertList.Count());


                if (AdvertsActive)
                {
                    // For each advert in the list;
                    // Create a timer, name it with the advert strings.
                    // When the time is up for each advert it prints to Chat.
					Adverts.Instance.AdvertList.ForEach(delegate(Adverts.Advert advert)
                    {

							// Setup the timers.
							Timer time = new Timer();
							time.AutoReset = true;
							time.Interval = 1000 * advert.Time;
							m_timers.Add(time, ReplaceFormatting(advert.Text));

							time.Elapsed += delegate(object sender, System.Timers.ElapsedEventArgs eventArgs)
							{
								Timer t = (Timer)sender;

								if(m_isDebugging)
									Console.WriteLine(m_timers[t]);

								ChatManager.Instance.SendPublicChatMessage(m_timers[t]);
							};

							if (advert.Active)
							{
								time.Enabled = true;
								time.Start();
							}
							else
							{
								time.Enabled = false;
								time.Stop();
							}

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

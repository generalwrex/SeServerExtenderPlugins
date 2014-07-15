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

using SEModAPIInternal.API.Common;
using SEModAPIInternal.API.Server;
using SEModAPIInternal.Support;

namespace MotdPlugin
{
    public class Core : PluginBase, IChatEventHandler
    {


        #region "Attributes"

        private static string m_dataFile;
        private static string m_assemblyFolder;

        private static string m_motdString;
        private static string m_motdTitle;
        private static string m_advertsString;
        private static string[] m_seperateAdverts;

        private static bool m_isDebugging;

        private static bool m_motdActive;
        private static bool m_advertsActive;

        private static bool m_motdChanged;
        private static bool m_advertsChanged;

        private Dictionary<Timer, string> timers = new Dictionary<Timer, string>();
        private List<string> AdvertList = new List<string>();

        #endregion

        #region "Constructors and Initializers"

        public Core()
        {
            // Default settings if the file doesn't exist.
            m_motdActive = false;
            m_advertsActive = false;

            m_motdChanged = false;
            m_advertsChanged = false;

            m_motdTitle = "[Message Of The Day]";
            m_motdString = "Write your Motd here";
            m_advertsString = "advert::10;;advert2::30";

            // Get the current path of the DLL.
            m_assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            m_dataFile = Path.Combine(m_assemblyFolder, "MotdPlugin_Settings.xml");

            try
            {
                // Create the data file if is doesn't exist.
                if (!File.Exists(m_dataFile))
                {
                    XDocument doc = new XDocument(
                        new XElement("Settings",
                        new XElement("MotdActive", m_motdActive),
                        new XElement("MotdTitle", m_motdTitle),
                        new XElement("MotdString", m_motdString),
                        new XElement("AdvertsActive", m_advertsActive),
                        new XElement("AdvertsString", m_advertsString)
                        )
                    );
                    doc.Save(m_dataFile);
                }
                Console.WriteLine("Motd Plugin '" + Id.ToString() + "' constructed!");
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
            this.LoadData();
            m_isDebugging = SandboxGameAssemblyWrapper.IsDebugging;
        }

        #endregion

        #region "Properties"

        // Properties for the Motd.
        [Category("Motd Plugin")]
        [Description("Enables or Disables the /motd chat command")]
        [Browsable(true)]
        [ReadOnly(false)]
        public bool MotdActive
        {
            get { return m_motdActive; }
            set
            {
                m_motdActive = value;
                m_motdChanged = true;
            }
        }

        [Category("Motd Plugin")]
        [Description("The Title of your Message of the day,  shown above the Motd text.")]
        [Browsable(true)]
        [ReadOnly(false)]
        public string MotdTitle
        {
            get { return m_motdTitle; }
            set
            {
                m_motdTitle = value;
                m_motdChanged = true;
            }
        }

        [Category("Motd Plugin")]
        [Description("Your Message of the day, dont make it longer than 4 lines of characters!")]
        [Browsable(true)]
        [ReadOnly(false)]
        public string Motd
        {
            get { return m_motdString; }
            set
            {
                m_motdString = value;
                m_motdChanged = true;
            }
        }

        // Properties for the Adverts.
        [Category("Adverts Plugin")]
        [Description("Enables or Disables the adverts from showing.")]
        [Browsable(true)]
        [ReadOnly(false)]
        public bool AdvertsActive
        {
            get { return m_advertsActive; }
            set
            {
                m_advertsActive = value;
                m_advertsChanged = true;
            }
        }

        [Category("Adverts Plugin")]
        [Description("AdvertText::TimeInSeconds, use ;; to add another advert   Example: advert::10;;advert2::30")]
        [Browsable(true)]
        [ReadOnly(false)]
        public string Adverts
        {
            get { return m_advertsString; }
            set
            {
                m_advertsString = value;
                m_advertsChanged = true;
            }
        }

        #endregion

        #region "EventHandlers"

        public override void Update()
        {
            // Checks and sets the new Motd text.        
            if (m_motdChanged && m_motdString != "" && m_motdTitle != "")
            {
                this.SaveData();

                m_motdChanged = false;
            }

            // Checks and sets the Adverts.
            if (m_advertsChanged && m_advertsString != "")
            {
                if (m_advertsActive)
                {
                    this.ClearAdverts();
                    this.ParseAdverts();
                }
                else
                {
                    this.ClearAdverts();
                }

                this.SaveData();

                m_advertsChanged = false;
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
                    ChatManager.Instance.SendPrivateChatMessage(id, m_motdString);
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

        #endregion

        #region "Methods"

        // Load settings from the XML file.
        private void LoadData()
        {
            try
            {
                if (File.Exists(m_dataFile))
                {
                    XDocument doc = XDocument.Load(m_dataFile);
                    foreach (XElement settings in doc.Descendants("Settings"))
                    {
                        if (settings.HasElements)
                        {
                            if (m_isDebugging)
                                Console.WriteLine("Motd Plugin - Loading Message Of The Day");

                            m_motdActive = Boolean.Parse(settings.Element("MotdActive").Value);
                            m_motdTitle = settings.Element("MotdTitle").Value;
                            m_motdString = settings.Element("MotdString").Value;

                            if (m_isDebugging)
                                Console.WriteLine("Motd Plugin - Loading Adverts");

                            m_advertsActive = Boolean.Parse(settings.Element("AdvertsActive").Value);
                            m_advertsString = settings.Element("AdvertsString").Value;

                            this.ParseAdverts();

                            Console.WriteLine("Motd Plugin - Data Loaded!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Motd Plugin - Error: " + ex.ToString());
            }

        }

        // Save data to the XML file.
        private void SaveData()
        {
            try
            {
                if (File.Exists(m_dataFile))
                {
                    XDocument xmlfile = XDocument.Load(m_dataFile);
                    foreach (XElement settings in xmlfile.Descendants("Settings"))
                    {
                        settings.SetElementValue("MotdActive", m_motdActive);
                        settings.SetElementValue("MotdTitle", m_motdTitle);
                        settings.SetElementValue("MotdString", m_motdString);
                        settings.SetElementValue("AdvertsActive", m_advertsActive);
                        settings.SetElementValue("AdvertsString", m_advertsString);
                    }

                    if (m_isDebugging)
                        Console.WriteLine("Motd Plugin - Saving Data File");

                    xmlfile.Save(m_dataFile);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Motd Plugin - Error: " + ex.ToString());
            }
        }

        private void ClearAdverts()
        {
            // Disable and Stop all timers in the Dictonary
            foreach (Timer timer in timers.Keys)
            {
                timer.Enabled = false;
                timer.Stop();
            }

            // Clear out the Dictionary and AdvertList list.
            timers.Clear();
            AdvertList.Clear();
        }

        private void ParseAdverts()
        {
            try
            {
                if (m_isDebugging)
                    Console.WriteLine("Motd Plugin - Parsing Adverts");

                // Seperate the adverts at the semicolons.
                m_seperateAdverts = m_advertsString.Split(new string[] { ";;" }, StringSplitOptions.None);

                // Add all the adverts to the AdvertList
                AdvertList.AddRange(m_seperateAdverts);

                if (m_advertsActive)
                {
                    // For each advert in the list;
                    // Create a timer, name it with the advert strings.
                    // When the time is up for each advert it prints to Chat.
                    AdvertList.ForEach(delegate(String advert)
                    {
                        string[] splitadverts = advert.Split(new string[] { "::" },
                            StringSplitOptions.None);

                        // Setup the timers.
                        Timer time = new Timer();
                        time.AutoReset = true;
                        time.Interval = 1000 * Int32.Parse(splitadverts.ElementAt(1));
                        timers.Add(time, splitadverts[0]);

                        time.Elapsed += delegate(object sender, System.Timers.ElapsedEventArgs eventArgs)
                        {
                            Timer t = (Timer)sender;
                            Console.WriteLine(timers[t]);
                            ChatManager.Instance.SendPublicChatMessage(timers[t]);
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

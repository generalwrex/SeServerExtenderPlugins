using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System.Reflection;


using SEModAPIExtensions.API.Plugin;
using SEModAPIExtensions.API.Plugin.Events;

using SEModAPIInternal.API.Common;
using SEModAPIInternal.Support;

namespace MotdPlugin
{
    public class Core : PluginBase
    {

        #region "Attributes"

        // Attributes for data saving/loadng
        private static string m_dataString;
        private static string m_dataFile;
        private static string m_assemblyFolder;

        private static string m_fileFormat;

        // Attributes for the Motd.
        private static bool m_motdActive;
        private static string m_motdString;
        private static string m_savedMotdString;

        // Attributes for the Adverts.
        private static bool m_advertsActive;
        private static string m_advertString;
        private static string m_savedAdvertString;
           
        #endregion

        #region "Constructors and Initializers"

        
        public Core()
        {
            // Default settings if the file doesn't exist.
            m_motdActive = false;
            m_motdString = "Write your Motd here";

            m_advertsActive = false;
            m_advertString = "advert:10/advert2:30";


            // Get the current path of the DLL.
            m_assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            m_dataFile = Path.Combine(m_assemblyFolder, "motdplugin_data.txt");


            m_fileFormat = m_advertString + "|" + m_motdString;

            try 
            { 
                // Create the data file if is doesn't exist.
                if (!File.Exists(m_dataFile))
                {
                    File.Create(m_dataFile);
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

            this.LoadData();
        }       

        #endregion


        #region "Properties"

        // Properties for the Motd.

        [Category("Motd Plugin")]
        [Browsable(true)]
        [ReadOnly(false)]
        public bool MotdActive
        {
            get { return m_motdActive; }
            set { m_motdActive = value; }
        }

        [Category("Motd Plugin")]
        [Browsable(true)]
        [ReadOnly(false)]
        public string Motd
        {
            get { return m_motdString; }
            set { m_motdString = value; }       
        }

        // Properties for the Adverts.

        [Category("Adverts Plugin")]
        [Browsable(true)]
        [ReadOnly(false)]
        public bool AdvertsActive
        {
            get { return m_advertsActive; }
            set { m_advertsActive = value; }
        }

        [Category("Adverts Plugin")]
        [Description("AdvertText:TimeInSeconds, use / to add another   advert:10/advert2:30")]
        [Browsable(true)]
        [ReadOnly(false)]
        public string Adverts
        {
            get { return m_advertString; }
            set { m_advertString = value; }
        }

        #endregion


        #region "EventHandlers"

        public override void Update()
        {
            // Updates 10x a second.

            // Checks and sets the new Motd text.
            if (m_motdString != m_savedMotdString && m_motdString != "")
            {
                this.SaveData();
                Console.WriteLine("Motd Plugin - New Motd: " + m_motdString);
            }

            if (m_advertString != m_savedAdvertString && m_advertString != "")
            {
                Console.WriteLine("Motd Plugin - New Adverts: " + m_advertString);
                this.SaveData();
            }
        }

        private void SaveData()
        {
            try
            {
                if (File.Exists(m_dataFile))
                {
                    File.WriteAllText(m_dataFile, m_fileFormat);
                    Console.WriteLine("Motd Plugin - Creating Data File");
                }
                else
                {

                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Motd Plugin - Error: " + ex.ToString());
            }      
        }

        #endregion


        #region "Methods"

        private void LoadData()
        {
            try
            {
                if (File.Exists(m_dataFile))
                {
                    Console.WriteLine("Motd Plugin - Loading Data");
                    string[] readText = File.ReadAllLines(m_dataFile);
                    foreach (string s in readText)
                    {
                        m_dataString += readText;
                    }
                    
                }
                else
                {
                    this.SaveData();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Motd Plugin - Error: " + ex.ToString());
            }

        }

        private void SendMOTD()
        {

        }

        private void SendAdverts()
        {

        }

        #endregion
    }
}

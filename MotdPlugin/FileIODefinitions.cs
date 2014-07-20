using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;


namespace MotdPlugin
{
	[XmlRoot("MotdPluginConfig")]
	public class MotdPluginData
	{
		public bool MotdActive;
		public string MotdTitle;
		public List<string> MotdLines;

		public bool AdvertsActive;
		public List<Adverts.Advert> AdvertsList;
			
		public MotdPluginData(){}

	}

	class FileIODefinitions
	{
		private static MotdPluginData m_motdPluginData;

		private static FileIODefinitions m_instance;

		private static Adverts m_adverts;

		private static string m_dataFile;
 

		public FileIODefinitions()
		{
			m_instance = this;

			string m_assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			m_dataFile = Path.Combine(m_assemblyFolder, "MotdPlugin_Settings.xml");

			if (!File.Exists(m_dataFile))
			{

				m_motdPluginData.MotdActive = false;
				m_motdPluginData.MotdTitle = "[Message Of The Day - %date%%time12%";

				string[] m_defaultMotd = {""};
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

		public static FileIODefinitions Instance
		{
			get
			{
				if (m_instance == null)
				{
					m_instance = new FileIODefinitions();
				}
				return m_instance;
			}
		}


		public void Load()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(MotdPluginData));
			TextReader textReader = new StreamReader(m_dataFile);
			m_motdPluginData = (MotdPluginData)serializer.Deserialize(textReader);
			textReader.Close();				
		}

		public void Save()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(MotdPluginData));
			TextWriter textWriter = new StreamWriter(m_dataFile);
			serializer.Serialize(textWriter, m_motdPluginData);
			textWriter.Close();
		}


	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

// TODO make sure this actually saves/loads an xml file!
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

		private static string m_dataFile;
 

		public FileIODefinitions()
		{
			m_instance = this;		
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


		public bool Load()
		{
			bool loaded = false;
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(MotdPluginData));
				TextReader textReader = new StreamReader(m_dataFile);
				m_motdPluginData = (MotdPluginData)serializer.Deserialize(textReader);
				textReader.Close();
				loaded = true;
			}
			catch(XmlException xmlex)
			{
				Console.WriteLine(xmlex.Message);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return loaded;
		}

		public bool Save()
		{
			bool saved = false;
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(MotdPluginData));
				TextWriter textWriter = new StreamWriter(m_dataFile);
				serializer.Serialize(textWriter, m_motdPluginData);
				textWriter.Close();
				saved = true;
			}
			catch (XmlException xmlex)
			{
				Console.WriteLine(xmlex.Message);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return saved;
		}


	}
}

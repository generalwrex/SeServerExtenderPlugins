using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SEModAPI.API.Definitions;

namespace MotdPlugin
{
	public class Adverts
	{
		public class Advert
		{
			public string Name { get; set; }
			public string Text { get; set; }
			public int Time { get; set; }
			public bool Active { get; set; }

			// additional properties
			public Advert(string name, string text, int time, bool active)
			{
				Name = name;
				Text = text;
				Time = time;
				Active = active;
			}
		}

		#region "Attributes"

		private static int m_advertId;

		private static Adverts m_instance;

		private static List<Advert> m_advertsList = new List<Advert>();

		private static Dictionary<string, Advert> m_advertsNameList = m_advertsList.ToDictionary(advert => advert.Name, advert => advert);

		#endregion 

		#region "Constructors And Initalizers"

		public Adverts()
		{
			m_instance = this;
		}

		#endregion

		#region "Properties"

		public static Adverts Instance
		{
			get
			{
				if (m_instance == null)
				{
					m_instance = new Adverts();
				}
				return m_instance;
			}
		}

		public List<Advert> AdvertList
		{
			get{ return m_advertsList; }
		}

		#endregion

		#region "Event Handlers"


		#endregion

		#region "Methods"


		public void AddAdvert(string name, string text, int time, bool active)
		{
			if ( m_advertsNameList.ContainsKey(name))
				return;
		
				m_advertsList.Add(new Advert(name, text, time, active));		
				//Console.WriteLine("User Management Plugin - Created User: {0}, with a Rank of {1}. ",userId, userRank);
		}

		public void UpdateAdvert(string name, string text, int time, bool active)
		{
			// Loop through the adverts to find the one with the specified name.
			foreach(Advert advert in m_advertsList)
			{
				// If it cant find the advert with the name in the list, return to the end
				if (!m_advertsNameList.ContainsKey(name))
				return;

				if (advert.Name == name)
				{
					advert.Name = name;
					//Console.WriteLine("User Management Plugin - Updated {0}'s Rank to {1}. ",userId, userRank);
				}
			}

		}
      
		// TODO : Remove Advert Function
		#endregion



	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagmentPlugin
{
	class RankManagment
	{

		public struct Rank
		{
			public string newRank;
			public string inheritsFrom;
		}

		public RankManagment()
		{
			m_instance = this;
		}

		#region "Attributes"

		private static RankManagment m_instance;

		private List<Rank> m_ranks;

		#endregion 

		#region "Constructors And Initalizers"


		#endregion

		#region "Properties"

		public static RankManagment Instance
		{
			get
			{
				if (m_instance == null)
				{
					m_instance = new RankManagment();
				}
				return m_instance;
			}
		}

		public List<Rank> Ranks
		{
			get
			{
				List<Rank> copy = new List<Rank>(m_ranks.ToArray());
				return copy;
			}
		}

		#endregion

		#region "Event Handlers"

		#endregion

		#region "Methods"

		public void NewRank(string rankName, string inheritsFrom)
		{
			Rank rank = new Rank();
			rank.newRank = rankName;
			rank.inheritsFrom = inheritsFrom;

			RankManagment.Instance.AddRank(rank, false);		
		}

		public void AddRank(Rank newRank, bool updating)
		{
			m_ranks.Add(newRank);			
		}

		
		#endregion

	}
}

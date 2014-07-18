using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagmentPlugin
{
	class UserManagement
	{

        public class User
        {
            // key properties
            public ulong UserId { get; set; }
            public string UserName { get; set; }
            public string UserRank { get; set; }

            // additional properties
            public User (ulong userId, string userName, string userRank)
            {
    			UserId = userId;
				UserName = userName;
				UserRank = userRank;
            }
        }

		#region "attributes"

		private static UserManagement m_instance;

		private static List<User> m_userList = new List<User>();
		private static Dictionary<ulong, User> m_userIDList = m_userList.ToDictionary(user => user.UserId, user => user);
	

		#endregion 

		#region "Constructors And Initalizers"

		public UserManagement()
		{
			m_instance = this;
            
		}

		#endregion

		#region "Properties"

		public static UserManagement Instance
		{
			get
			{
				if (m_instance == null)
				{
					m_instance = new UserManagement();
				}
				return m_instance;
			}
		}

		#endregion

		#region "Event Handlers"


		#endregion

		#region "Methods"


		public void AddUser(string userName, ulong userId, string userRank)
		{
			if(m_userIDList.ContainsKey(userId))
				return;

				m_userList.Add(new User(userId, userName, userRank));		
				Console.WriteLine("User Management Plugin - Created User: {0}, with a Rank of {1}. ",userId, userRank);
		}

		public void UpdateUserRank(ulong userId, string userRank)
		{
			

			foreach(User user in m_userList)
			{
				if(m_userIDList.ContainsKey(userId))
				return;

				if(user.UserId == userId)
				{
					user.UserRank = userRank;
					Console.WriteLine("User Management Plugin - Updated {0}'s Rank to {1}. ",userId, userRank);
				}
			}

		}

		public string GetUserRank(ulong userId)
		{
			string userRank = "";
			foreach (User user in m_userList)
			{
				if (m_userIDList.ContainsKey(userId))
				{
					if (user.UserId == userId)
					{
						userRank = user.UserRank;
					}
				}		
			}
			return userRank;
		}

		public List<User> GetUsers()
		{
			return m_userList;
		}
        
		#endregion
	}
}

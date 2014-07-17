using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagmentPlugin
{
	class UserManagment
	{

		public struct User
		{
			public ulong userId;
			public string addToRank;
		}

		public UserManagment()
		{
			m_instance = this;
		}

		#region "Attributes"

		private static UserManagment m_instance;

		private List<User> m_users;

		#endregion 

		#region "Constructors And Initalizers"


		#endregion

		#region "Properties"

		public static UserManagment Instance
		{
			get
			{
				if (m_instance == null)
				{
					m_instance = new UserManagment();
				}
				return m_instance;
			}
		}

		public List<User> Users
		{
			get
			{
				List<User> copy = new List<User>(m_users.ToArray());
				return copy;
			}
		}

		#endregion

		#region "Event Handlers"


		#endregion

		#region "Methods"

		public void NewUser(ulong newUserId, string addToRank)
		{
			User user = new User();
			user.userId = newUserId;
			user.addToRank = addToRank;

			UserManagment.Instance.AddUser(user);		
		}

		private void AddUser(User newUser)
		{
			m_users.Add(newUser);
		}


		// will link players 64 bit id's to their names
		private string GetSteamName(ulong id)
		{
			string steamName = "";

			return steamName;
		}

		#endregion

	}
}

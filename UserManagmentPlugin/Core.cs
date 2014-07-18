using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SEModAPIExtensions.API; //required for plugins
using SEModAPIExtensions.API.Plugin; //required for plugins
using SEModAPIExtensions.API.Plugin.Events; // plugin events

using SEModAPIInternal.Support;
using SEModAPIInternal.API.Common;


namespace UserManagmentPlugin
{

	public class Core : PluginBase
	{
		#region "Attributes"

		static UserManagementForm m_userManagmentForm;

		private static bool m_userManagmentWindowOpen;

		#endregion

		#region "Constructors and Initializers

		// Called when the server first launches
		public Core()
		{
			m_userManagmentForm = new UserManagementForm();
			
			Console.WriteLine("User Management Plugin '" + Id.ToString() + "' constructed!");			
		}

		// Called when the server finishes loading
		public override void Init()
		{
			Console.WriteLine("User Management Plugin '" + Id.ToString() + "' Initailized!");

			UserManagement.Instance.AddUser("Wrex", 1234567, "Guest");
			UserManagement.Instance.AddUser("Wrex", 1264567, "Guest");
			UserManagement.Instance.AddUser("Wrex", 1287667, "Guest");
			UserManagement.Instance.AddUser("Wrex", 1864677, "Guest");
			UserManagement.Instance.AddUser("Wrex", 9434578, "Guest");
			UserManagement.Instance.AddUser("Wrex", 1273367, "Guest");

			UserManagement.Instance.UpdateUserRank(1234567, "Admin");

		}

		#endregion

		#region "Properties"

		[Category("User Managment Plugin")]
		[DisplayName("Open User Managment Window")]
		[Description("Opens the user managment interface for assigning ranks to users, and permissions to ranks!")]
		[Browsable(true)]
		[ReadOnly(false)]
		public bool OpenUserManagmentWindow
		{
			get { return m_userManagmentWindowOpen; }
			set 
			{
				m_userManagmentWindowOpen = value;
				if (value) { m_userManagmentForm.ShowDialog(); }
			}
		}

		#endregion

		#region "Event Handlers"

		public override void Update()
		{
		}

		public override void Shutdown()
		{
		}

		#endregion

		#region "Methods"

		#endregion


	}
}

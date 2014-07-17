using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

using SEModAPIInternal.Support;
using SEModAPIInternal.API.Common;
using SEModAPIInternal.API.Server;

namespace UserManagmentPlugin
{
	public partial class UserManagmentForm : Form
	{
		#region "Attributes

		private System.Windows.Forms.Timer m_updatePlayerList;
	
		#endregion

		#region "Constructors and Initializers"

		public UserManagmentForm()
		{
			InitializeComponent();

			 //Update the title bar text with the assembly version
			this.Text = "SeServerExtender User Manager " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

			// Connected Players Refresh Timer
			m_updatePlayerList = new System.Windows.Forms.Timer();
			m_updatePlayerList.Interval = 1000;
			m_updatePlayerList.Tick += new EventHandler(RefreshConnectedPlayers);
			m_updatePlayerList.Start();

			// test user
			ListViewItem user = LST_UserManagement_ConnectedPlayers.Items.Add("Im a Player!");
			user.SubItems.Add("12345678901234567"); 
							   			
		}

		#endregion

		#region "Controls"

		private void BTN_UserManagment_AddUser_Click(object sender, EventArgs e)
		{
			LST_UserManagement_Users.BeginUpdate();

			foreach (ListViewItem item in LST_UserManagement_ConnectedPlayers.SelectedItems)
			{
				ListViewItem lvitem = LST_UserManagement_Users.Items.Add(item.Text);
				lvitem.SubItems.Add(item.SubItems[1].Text);
			}

			LST_UserManagement_Users.EndUpdate();
		}

		private void LST_UserManagement_ConnectedPlayers_DoubleClick(object sender, EventArgs e)
		{
			BTN_UserManagment_AddUser_Click(null, null);
		}

		#endregion

		#region "Event Handlers"

		private void RefreshConnectedPlayers(object sender, EventArgs e)
		{
			LST_UserManagement_ConnectedPlayers.BeginUpdate();

			List<ulong> connectedPlayers = ServerNetworkManager.Instance.GetConnectedPlayers();
			if (connectedPlayers.Count != LST_UserManagement_ConnectedPlayers.Items.Count)
			{
				LST_UserManagement_ConnectedPlayers.Items.Clear();
				foreach (ulong remoteUserId in connectedPlayers)
				{
					LST_UserManagement_ConnectedPlayers.Items.Add(remoteUserId.ToString());
				}
			}

			LST_UserManagement_ConnectedPlayers.EndUpdate();
		}

		#endregion

		#region "Methods"

		#endregion


	}
}

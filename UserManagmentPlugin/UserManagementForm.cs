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
	public partial class UserManagementForm : Form
	{
		#region "Attributes

		private System.Windows.Forms.Timer m_updatePlayerList;

		#endregion

		#region "Constructors and Initializers"

		public UserManagementForm()
		{
			InitializeComponent();

			 //Update the title bar text with the assembly version
			this.Text = "SeServerExtender User Manager " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

			// Connected Players Refresh Timer
			m_updatePlayerList = new System.Windows.Forms.Timer();
			m_updatePlayerList.Interval = 5000;
			m_updatePlayerList.Tick += new EventHandler(RefreshConnectedPlayers);
			m_updatePlayerList.Start();

		}

		#endregion


		#region "Event Handlers"

		private void RefreshConnectedPlayers(object sender, EventArgs e)
		{

		}

		#endregion

		#region "Controls"


		#endregion

		#region "Methods"

		#endregion
	}
}

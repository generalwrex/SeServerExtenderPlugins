using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MotdPlugin
{
	public partial class MotdPluginConfigForm : Form
	{

		#region "Attributes"

		private static MotdPluginConfigForm m_instance;

		private static MotdPluginCore m_motdPluginCore;

		private static Adverts m_adverts;
		#endregion

		#region "Constructors And Initalizers"

		public MotdPluginConfigForm()
		{
			InitializeComponent();

			m_instance = this;
		}

		#endregion

		#region "Properties"

		public static MotdPluginConfigForm Instance
		{
			get
			{
				if (m_instance == null)
				{
					m_instance = new MotdPluginConfigForm();
				}
				return m_instance;
			}
		}

		// Set the status bar text
		public string SetStatus
		{
			set { MotdConfig_Status.Text = value; }
		}

		#endregion

		#region "Control"

		private void BTN_MotdPlugin_Motd_Save_Click(object sender, EventArgs e)
		{
			m_motdPluginCore.MotdActive = CHK_MotdPlugin_Motd_Active.Checked;
			m_motdPluginCore.MotdTitle = TXT_MotdPlugin_Motd_Title.Text;
			m_motdPluginCore.MotdLines = TXT_MotdPlugin_Motd_Body.Lines.ToList();
		}

		private void BTN_MotdPlugin_Adverts_NewAdvert_Click(object sender, EventArgs e)
		{
			string name = TXT_MotdPlugin_Adverts_Name.Text;
			string text = TXT_MotdPlugin_Adverts_Text.Text;
			int time = (int)NUM_MotdPlugin_Adverts_Time.Value;
			bool active = CHK_MotdPlugin_Adverts_EnableAdvert.Checked;

			m_adverts.AddAdvert(name, text, time, active);

			m_motdPluginCore.AdvertsChanged = true;
		}

		private void BTN_MotdPlugin_Adverts_Update_Click(object sender, EventArgs e)
		{

		}

		private void BTN_MotdPlugin_Adverts_DeleteAdvert_Click(object sender, EventArgs e)
		{

		}

		private void LST_AdvertsConfig_Adverts_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		#endregion

		#region "Methods"

		#endregion

	}
}

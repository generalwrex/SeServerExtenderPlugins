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

		private static bool m_motdActive;
		private static bool m_advertsActive;

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

		public bool MotdActive
		{
			get { return m_motdActive; }
			set { m_motdActive = value; }
		}

		public bool AdvertsActive
		{
			get { return m_advertsActive; }
			set { m_advertsActive = value; }
		}

		// Set the status bar text
		public string SetStatus
		{
			set { MotdConfig_Status.Text = value; }
		}

		#endregion

		#region "Control"

		private void CHK_MotdPlugin_Motd_Active_CheckedChanged(object sender, EventArgs e)
		{
			m_motdActive = CHK_MotdPlugin_Motd_Active.Checked;
		}

		private void BTN_MotdPlugin_Motd_Save_Click(object sender, EventArgs e)
		{

		}

		#endregion

		#region "Methods"

		public List<string> GetMotdLines()
		{
			return TXT_MotdPlugin_Motd_Body.Lines.ToList() ;
		}

		public string GetMotdTitle()
		{
			return TXT_MotdPlugin_Motd_Title.Text;
		}

		#endregion

	}
}

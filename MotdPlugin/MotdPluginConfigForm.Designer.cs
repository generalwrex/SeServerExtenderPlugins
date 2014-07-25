namespace MotdPlugin
{
	partial class MotdPluginConfigForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotdPluginConfigForm));
			this.LST_Column_Advert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.MotdConfig_Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.TAB_MotdPlugin_Advets_Page = new System.Windows.Forms.TabPage();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.splitContainer5 = new System.Windows.Forms.SplitContainer();
			this.GRP_AdvertsConfig_Adverts = new System.Windows.Forms.GroupBox();
			this.LST_AdvertsConfig_Adverts = new System.Windows.Forms.ListView();
			this.LST_Adverts_Column_AdvertName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LST_Adverts_Column_AdvertTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LST_Adverts_Column_AdvertText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.GRP_AdvertsConfig_Selected_New = new System.Windows.Forms.GroupBox();
			this.BTN_MotdPlugin_Adverts_DeleteAdvert = new System.Windows.Forms.Button();
			this.BTN_MotdPlugin_Adverts_New = new System.Windows.Forms.Button();
			this.TXT_MotdPlugin_Adverts_Text = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.NUM_MotdPlugin_Adverts_Time = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.TXT_MotdPlugin_Adverts_Name = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.TAB_MotdPlugin_Motd_Page = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.GRP_MotdPlugin_Motd_Title = new System.Windows.Forms.GroupBox();
			this.TXT_MotdPlugin_Motd_Title = new System.Windows.Forms.TextBox();
			this.GRP_MotdPlugin_Motd_Body = new System.Windows.Forms.GroupBox();
			this.TXT_MotdPlugin_Motd_Body = new System.Windows.Forms.TextBox();
			this.BTN_MotdPlugin_Motd_Save = new System.Windows.Forms.Button();
			this.CHK_MotdPlugin_Motd_Active = new System.Windows.Forms.CheckBox();
			this.TAB_MotdPlugin = new System.Windows.Forms.TabControl();
			this.CHK_MotdPlugin_Adverts_EnableAdvert = new System.Windows.Forms.CheckBox();
			this.BTN_MotdPlugin_Adverts_Update = new System.Windows.Forms.Button();
			this.CHK_MotdPlugin_Adverts_Active = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.webBrowser2 = new System.Windows.Forms.WebBrowser();
			this.StatusBar.SuspendLayout();
			this.TAB_MotdPlugin_Advets_Page.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
			this.splitContainer5.Panel1.SuspendLayout();
			this.splitContainer5.Panel2.SuspendLayout();
			this.splitContainer5.SuspendLayout();
			this.GRP_AdvertsConfig_Adverts.SuspendLayout();
			this.GRP_AdvertsConfig_Selected_New.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NUM_MotdPlugin_Adverts_Time)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.TAB_MotdPlugin_Motd_Page.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			this.GRP_MotdPlugin_Motd_Title.SuspendLayout();
			this.GRP_MotdPlugin_Motd_Body.SuspendLayout();
			this.TAB_MotdPlugin.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// LST_Column_Advert
			// 
			this.LST_Column_Advert.Text = "Advert";
			this.LST_Column_Advert.Width = 198;
			// 
			// MotdConfig_Status
			// 
			this.MotdConfig_Status.Name = "MotdConfig_Status";
			this.MotdConfig_Status.Size = new System.Drawing.Size(48, 17);
			this.MotdConfig_Status.Text = "Ready...";
			// 
			// StatusBar
			// 
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MotdConfig_Status});
			this.StatusBar.Location = new System.Drawing.Point(0, 318);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(601, 22);
			this.StatusBar.TabIndex = 0;
			this.StatusBar.Text = "statusStrip1";
			// 
			// TAB_MotdPlugin_Advets_Page
			// 
			this.TAB_MotdPlugin_Advets_Page.Controls.Add(this.splitContainer3);
			this.TAB_MotdPlugin_Advets_Page.Location = new System.Drawing.Point(4, 22);
			this.TAB_MotdPlugin_Advets_Page.Name = "TAB_MotdPlugin_Advets_Page";
			this.TAB_MotdPlugin_Advets_Page.Padding = new System.Windows.Forms.Padding(3);
			this.TAB_MotdPlugin_Advets_Page.Size = new System.Drawing.Size(593, 292);
			this.TAB_MotdPlugin_Advets_Page.TabIndex = 1;
			this.TAB_MotdPlugin_Advets_Page.Text = "Adverts Config";
			this.TAB_MotdPlugin_Advets_Page.UseVisualStyleBackColor = true;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(3, 3);
			this.splitContainer3.Name = "splitContainer3";
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.splitContainer5);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer3.Size = new System.Drawing.Size(587, 286);
			this.splitContainer3.SplitterDistance = 313;
			this.splitContainer3.TabIndex = 0;
			// 
			// splitContainer5
			// 
			this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer5.Location = new System.Drawing.Point(0, 0);
			this.splitContainer5.Name = "splitContainer5";
			this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer5.Panel1
			// 
			this.splitContainer5.Panel1.Controls.Add(this.GRP_AdvertsConfig_Adverts);
			// 
			// splitContainer5.Panel2
			// 
			this.splitContainer5.Panel2.Controls.Add(this.GRP_AdvertsConfig_Selected_New);
			this.splitContainer5.Size = new System.Drawing.Size(313, 286);
			this.splitContainer5.SplitterDistance = 130;
			this.splitContainer5.TabIndex = 0;
			// 
			// GRP_AdvertsConfig_Adverts
			// 
			this.GRP_AdvertsConfig_Adverts.Controls.Add(this.LST_AdvertsConfig_Adverts);
			this.GRP_AdvertsConfig_Adverts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GRP_AdvertsConfig_Adverts.Location = new System.Drawing.Point(0, 0);
			this.GRP_AdvertsConfig_Adverts.Name = "GRP_AdvertsConfig_Adverts";
			this.GRP_AdvertsConfig_Adverts.Size = new System.Drawing.Size(313, 130);
			this.GRP_AdvertsConfig_Adverts.TabIndex = 1;
			this.GRP_AdvertsConfig_Adverts.TabStop = false;
			this.GRP_AdvertsConfig_Adverts.Text = "Adverts";
			// 
			// LST_AdvertsConfig_Adverts
			// 
			this.LST_AdvertsConfig_Adverts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LST_Adverts_Column_AdvertName,
            this.LST_Adverts_Column_AdvertTime,
            this.LST_Adverts_Column_AdvertText});
			this.LST_AdvertsConfig_Adverts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LST_AdvertsConfig_Adverts.Location = new System.Drawing.Point(3, 16);
			this.LST_AdvertsConfig_Adverts.Name = "LST_AdvertsConfig_Adverts";
			this.LST_AdvertsConfig_Adverts.Size = new System.Drawing.Size(307, 111);
			this.LST_AdvertsConfig_Adverts.TabIndex = 0;
			this.LST_AdvertsConfig_Adverts.UseCompatibleStateImageBehavior = false;
			this.LST_AdvertsConfig_Adverts.View = System.Windows.Forms.View.Details;
			this.LST_AdvertsConfig_Adverts.SelectedIndexChanged += new System.EventHandler(this.LST_AdvertsConfig_Adverts_SelectedIndexChanged);
			// 
			// LST_Adverts_Column_AdvertName
			// 
			this.LST_Adverts_Column_AdvertName.Text = "Name";
			this.LST_Adverts_Column_AdvertName.Width = 54;
			// 
			// LST_Adverts_Column_AdvertTime
			// 
			this.LST_Adverts_Column_AdvertTime.Text = "Time";
			this.LST_Adverts_Column_AdvertTime.Width = 53;
			// 
			// LST_Adverts_Column_AdvertText
			// 
			this.LST_Adverts_Column_AdvertText.Text = "Advert Text";
			this.LST_Adverts_Column_AdvertText.Width = 177;
			// 
			// GRP_AdvertsConfig_Selected_New
			// 
			this.GRP_AdvertsConfig_Selected_New.Controls.Add(this.CHK_MotdPlugin_Adverts_Active);
			this.GRP_AdvertsConfig_Selected_New.Controls.Add(this.BTN_MotdPlugin_Adverts_Update);
			this.GRP_AdvertsConfig_Selected_New.Controls.Add(this.CHK_MotdPlugin_Adverts_EnableAdvert);
			this.GRP_AdvertsConfig_Selected_New.Controls.Add(this.BTN_MotdPlugin_Adverts_DeleteAdvert);
			this.GRP_AdvertsConfig_Selected_New.Controls.Add(this.BTN_MotdPlugin_Adverts_New);
			this.GRP_AdvertsConfig_Selected_New.Controls.Add(this.TXT_MotdPlugin_Adverts_Text);
			this.GRP_AdvertsConfig_Selected_New.Controls.Add(this.label3);
			this.GRP_AdvertsConfig_Selected_New.Controls.Add(this.label2);
			this.GRP_AdvertsConfig_Selected_New.Controls.Add(this.NUM_MotdPlugin_Adverts_Time);
			this.GRP_AdvertsConfig_Selected_New.Controls.Add(this.label1);
			this.GRP_AdvertsConfig_Selected_New.Controls.Add(this.TXT_MotdPlugin_Adverts_Name);
			this.GRP_AdvertsConfig_Selected_New.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GRP_AdvertsConfig_Selected_New.Location = new System.Drawing.Point(0, 0);
			this.GRP_AdvertsConfig_Selected_New.Name = "GRP_AdvertsConfig_Selected_New";
			this.GRP_AdvertsConfig_Selected_New.Size = new System.Drawing.Size(313, 152);
			this.GRP_AdvertsConfig_Selected_New.TabIndex = 0;
			this.GRP_AdvertsConfig_Selected_New.TabStop = false;
			this.GRP_AdvertsConfig_Selected_New.Text = "Selected Advert Details";
			// 
			// BTN_MotdPlugin_Adverts_DeleteAdvert
			// 
			this.BTN_MotdPlugin_Adverts_DeleteAdvert.Location = new System.Drawing.Point(234, 101);
			this.BTN_MotdPlugin_Adverts_DeleteAdvert.Name = "BTN_MotdPlugin_Adverts_DeleteAdvert";
			this.BTN_MotdPlugin_Adverts_DeleteAdvert.Size = new System.Drawing.Size(66, 23);
			this.BTN_MotdPlugin_Adverts_DeleteAdvert.TabIndex = 9;
			this.BTN_MotdPlugin_Adverts_DeleteAdvert.Text = "Delete";
			this.BTN_MotdPlugin_Adverts_DeleteAdvert.UseVisualStyleBackColor = true;
			this.BTN_MotdPlugin_Adverts_DeleteAdvert.Click += new System.EventHandler(this.BTN_MotdPlugin_Adverts_DeleteAdvert_Click);
			// 
			// BTN_MotdPlugin_Adverts_New
			// 
			this.BTN_MotdPlugin_Adverts_New.Location = new System.Drawing.Point(5, 101);
			this.BTN_MotdPlugin_Adverts_New.Name = "BTN_MotdPlugin_Adverts_New";
			this.BTN_MotdPlugin_Adverts_New.Size = new System.Drawing.Size(54, 23);
			this.BTN_MotdPlugin_Adverts_New.TabIndex = 8;
			this.BTN_MotdPlugin_Adverts_New.Text = "New";
			this.BTN_MotdPlugin_Adverts_New.UseVisualStyleBackColor = true;
			this.BTN_MotdPlugin_Adverts_New.Click += new System.EventHandler(this.BTN_MotdPlugin_Adverts_NewAdvert_Click);
			// 
			// TXT_MotdPlugin_Adverts_Text
			// 
			this.TXT_MotdPlugin_Adverts_Text.Location = new System.Drawing.Point(5, 75);
			this.TXT_MotdPlugin_Adverts_Text.Name = "TXT_MotdPlugin_Adverts_Text";
			this.TXT_MotdPlugin_Adverts_Text.Size = new System.Drawing.Size(295, 20);
			this.TXT_MotdPlugin_Adverts_Text.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Text:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(238, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Time:";
			// 
			// NUM_MotdPlugin_Adverts_Time
			// 
			this.NUM_MotdPlugin_Adverts_Time.Location = new System.Drawing.Point(241, 35);
			this.NUM_MotdPlugin_Adverts_Time.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.NUM_MotdPlugin_Adverts_Time.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.NUM_MotdPlugin_Adverts_Time.Name = "NUM_MotdPlugin_Adverts_Time";
			this.NUM_MotdPlugin_Adverts_Time.Size = new System.Drawing.Size(59, 20);
			this.NUM_MotdPlugin_Adverts_Time.TabIndex = 2;
			this.NUM_MotdPlugin_Adverts_Time.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name:";
			// 
			// TXT_MotdPlugin_Adverts_Name
			// 
			this.TXT_MotdPlugin_Adverts_Name.Location = new System.Drawing.Point(5, 35);
			this.TXT_MotdPlugin_Adverts_Name.Name = "TXT_MotdPlugin_Adverts_Name";
			this.TXT_MotdPlugin_Adverts_Name.Size = new System.Drawing.Size(230, 20);
			this.TXT_MotdPlugin_Adverts_Name.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.webBrowser1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(270, 286);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Help";
			// 
			// webBrowser1
			// 
			this.webBrowser1.AllowNavigation = false;
			this.webBrowser1.AllowWebBrowserDrop = false;
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 16);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(264, 267);
			this.webBrowser1.TabIndex = 0;
			// 
			// TAB_MotdPlugin_Motd_Page
			// 
			this.TAB_MotdPlugin_Motd_Page.Controls.Add(this.splitContainer1);
			this.TAB_MotdPlugin_Motd_Page.Location = new System.Drawing.Point(4, 22);
			this.TAB_MotdPlugin_Motd_Page.Name = "TAB_MotdPlugin_Motd_Page";
			this.TAB_MotdPlugin_Motd_Page.Padding = new System.Windows.Forms.Padding(3);
			this.TAB_MotdPlugin_Motd_Page.Size = new System.Drawing.Size(593, 292);
			this.TAB_MotdPlugin_Motd_Page.TabIndex = 0;
			this.TAB_MotdPlugin_Motd_Page.Text = "Motd Config";
			this.TAB_MotdPlugin_Motd_Page.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(587, 286);
			this.splitContainer1.SplitterDistance = 283;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.BTN_MotdPlugin_Motd_Save);
			this.splitContainer2.Panel2.Controls.Add(this.CHK_MotdPlugin_Motd_Active);
			this.splitContainer2.Size = new System.Drawing.Size(283, 286);
			this.splitContainer2.SplitterDistance = 226;
			this.splitContainer2.TabIndex = 1;
			// 
			// splitContainer4
			// 
			this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Name = "splitContainer4";
			this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.GRP_MotdPlugin_Motd_Title);
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.GRP_MotdPlugin_Motd_Body);
			this.splitContainer4.Size = new System.Drawing.Size(283, 226);
			this.splitContainer4.SplitterDistance = 42;
			this.splitContainer4.TabIndex = 0;
			// 
			// GRP_MotdPlugin_Motd_Title
			// 
			this.GRP_MotdPlugin_Motd_Title.Controls.Add(this.TXT_MotdPlugin_Motd_Title);
			this.GRP_MotdPlugin_Motd_Title.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GRP_MotdPlugin_Motd_Title.Location = new System.Drawing.Point(0, 0);
			this.GRP_MotdPlugin_Motd_Title.Name = "GRP_MotdPlugin_Motd_Title";
			this.GRP_MotdPlugin_Motd_Title.Size = new System.Drawing.Size(283, 42);
			this.GRP_MotdPlugin_Motd_Title.TabIndex = 2;
			this.GRP_MotdPlugin_Motd_Title.TabStop = false;
			this.GRP_MotdPlugin_Motd_Title.Text = "Message Of The Day Title";
			// 
			// TXT_MotdPlugin_Motd_Title
			// 
			this.TXT_MotdPlugin_Motd_Title.Dock = System.Windows.Forms.DockStyle.Left;
			this.TXT_MotdPlugin_Motd_Title.Location = new System.Drawing.Point(3, 16);
			this.TXT_MotdPlugin_Motd_Title.Name = "TXT_MotdPlugin_Motd_Title";
			this.TXT_MotdPlugin_Motd_Title.Size = new System.Drawing.Size(231, 20);
			this.TXT_MotdPlugin_Motd_Title.TabIndex = 0;
			this.TXT_MotdPlugin_Motd_Title.Text = "[Message Of The Day - %date%%time12%\r\n]";
			// 
			// GRP_MotdPlugin_Motd_Body
			// 
			this.GRP_MotdPlugin_Motd_Body.Controls.Add(this.TXT_MotdPlugin_Motd_Body);
			this.GRP_MotdPlugin_Motd_Body.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GRP_MotdPlugin_Motd_Body.Location = new System.Drawing.Point(0, 0);
			this.GRP_MotdPlugin_Motd_Body.Name = "GRP_MotdPlugin_Motd_Body";
			this.GRP_MotdPlugin_Motd_Body.Size = new System.Drawing.Size(283, 180);
			this.GRP_MotdPlugin_Motd_Body.TabIndex = 2;
			this.GRP_MotdPlugin_Motd_Body.TabStop = false;
			this.GRP_MotdPlugin_Motd_Body.Text = "Message Of The Day Body";
			// 
			// TXT_MotdPlugin_Motd_Body
			// 
			this.TXT_MotdPlugin_Motd_Body.AllowDrop = true;
			this.TXT_MotdPlugin_Motd_Body.Location = new System.Drawing.Point(7, 20);
			this.TXT_MotdPlugin_Motd_Body.MaxLength = 1000;
			this.TXT_MotdPlugin_Motd_Body.Multiline = true;
			this.TXT_MotdPlugin_Motd_Body.Name = "TXT_MotdPlugin_Motd_Body";
			this.TXT_MotdPlugin_Motd_Body.Size = new System.Drawing.Size(228, 118);
			this.TXT_MotdPlugin_Motd_Body.TabIndex = 0;
			this.TXT_MotdPlugin_Motd_Body.Text = resources.GetString("TXT_MotdPlugin_Motd_Body.Text");
			this.TXT_MotdPlugin_Motd_Body.WordWrap = false;
			// 
			// BTN_MotdPlugin_Motd_Save
			// 
			this.BTN_MotdPlugin_Motd_Save.Location = new System.Drawing.Point(150, 16);
			this.BTN_MotdPlugin_Motd_Save.Name = "BTN_MotdPlugin_Motd_Save";
			this.BTN_MotdPlugin_Motd_Save.Size = new System.Drawing.Size(101, 22);
			this.BTN_MotdPlugin_Motd_Save.TabIndex = 4;
			this.BTN_MotdPlugin_Motd_Save.Text = "Save Changes";
			this.BTN_MotdPlugin_Motd_Save.UseVisualStyleBackColor = true;
			// 
			// CHK_MotdPlugin_Motd_Active
			// 
			this.CHK_MotdPlugin_Motd_Active.AutoSize = true;
			this.CHK_MotdPlugin_Motd_Active.Location = new System.Drawing.Point(25, 20);
			this.CHK_MotdPlugin_Motd_Active.Name = "CHK_MotdPlugin_Motd_Active";
			this.CHK_MotdPlugin_Motd_Active.Size = new System.Drawing.Size(92, 17);
			this.CHK_MotdPlugin_Motd_Active.TabIndex = 5;
			this.CHK_MotdPlugin_Motd_Active.Text = "Motd Enabled";
			this.CHK_MotdPlugin_Motd_Active.UseVisualStyleBackColor = true;
			// 
			// TAB_MotdPlugin
			// 
			this.TAB_MotdPlugin.Controls.Add(this.TAB_MotdPlugin_Motd_Page);
			this.TAB_MotdPlugin.Controls.Add(this.TAB_MotdPlugin_Advets_Page);
			this.TAB_MotdPlugin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TAB_MotdPlugin.Location = new System.Drawing.Point(0, 0);
			this.TAB_MotdPlugin.Name = "TAB_MotdPlugin";
			this.TAB_MotdPlugin.SelectedIndex = 0;
			this.TAB_MotdPlugin.Size = new System.Drawing.Size(601, 318);
			this.TAB_MotdPlugin.TabIndex = 1;
			// 
			// CHK_MotdPlugin_Adverts_EnableAdvert
			// 
			this.CHK_MotdPlugin_Adverts_EnableAdvert.AutoSize = true;
			this.CHK_MotdPlugin_Adverts_EnableAdvert.Location = new System.Drawing.Point(139, 105);
			this.CHK_MotdPlugin_Adverts_EnableAdvert.Name = "CHK_MotdPlugin_Adverts_EnableAdvert";
			this.CHK_MotdPlugin_Adverts_EnableAdvert.Size = new System.Drawing.Size(65, 17);
			this.CHK_MotdPlugin_Adverts_EnableAdvert.TabIndex = 10;
			this.CHK_MotdPlugin_Adverts_EnableAdvert.Text = "Enabled";
			this.CHK_MotdPlugin_Adverts_EnableAdvert.UseVisualStyleBackColor = true;
			// 
			// BTN_MotdPlugin_Adverts_Update
			// 
			this.BTN_MotdPlugin_Adverts_Update.Location = new System.Drawing.Point(65, 101);
			this.BTN_MotdPlugin_Adverts_Update.Name = "BTN_MotdPlugin_Adverts_Update";
			this.BTN_MotdPlugin_Adverts_Update.Size = new System.Drawing.Size(54, 23);
			this.BTN_MotdPlugin_Adverts_Update.TabIndex = 11;
			this.BTN_MotdPlugin_Adverts_Update.Text = "Update";
			this.BTN_MotdPlugin_Adverts_Update.UseVisualStyleBackColor = true;
			this.BTN_MotdPlugin_Adverts_Update.Click += new System.EventHandler(this.BTN_MotdPlugin_Adverts_Update_Click);
			// 
			// CHK_MotdPlugin_Adverts_Active
			// 
			this.CHK_MotdPlugin_Adverts_Active.AutoSize = true;
			this.CHK_MotdPlugin_Adverts_Active.Location = new System.Drawing.Point(9, 132);
			this.CHK_MotdPlugin_Adverts_Active.Name = "CHK_MotdPlugin_Adverts_Active";
			this.CHK_MotdPlugin_Adverts_Active.Size = new System.Drawing.Size(104, 17);
			this.CHK_MotdPlugin_Adverts_Active.TabIndex = 12;
			this.CHK_MotdPlugin_Adverts_Active.Text = "Adverts Enabled";
			this.CHK_MotdPlugin_Adverts_Active.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.webBrowser2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(300, 286);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Help";
			// 
			// webBrowser2
			// 
			this.webBrowser2.AllowNavigation = false;
			this.webBrowser2.AllowWebBrowserDrop = false;
			this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser2.Location = new System.Drawing.Point(3, 16);
			this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser2.Name = "webBrowser2";
			this.webBrowser2.Size = new System.Drawing.Size(294, 267);
			this.webBrowser2.TabIndex = 0;
			// 
			// MotdPluginConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 340);
			this.Controls.Add(this.TAB_MotdPlugin);
			this.Controls.Add(this.StatusBar);
			this.ImeMode = System.Windows.Forms.ImeMode.On;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MotdPluginConfigForm";
			this.Text = "Motd Plugin Config";
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			this.TAB_MotdPlugin_Advets_Page.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.splitContainer5.Panel1.ResumeLayout(false);
			this.splitContainer5.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
			this.splitContainer5.ResumeLayout(false);
			this.GRP_AdvertsConfig_Adverts.ResumeLayout(false);
			this.GRP_AdvertsConfig_Selected_New.ResumeLayout(false);
			this.GRP_AdvertsConfig_Selected_New.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NUM_MotdPlugin_Adverts_Time)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.TAB_MotdPlugin_Motd_Page.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
			this.splitContainer4.ResumeLayout(false);
			this.GRP_MotdPlugin_Motd_Title.ResumeLayout(false);
			this.GRP_MotdPlugin_Motd_Title.PerformLayout();
			this.GRP_MotdPlugin_Motd_Body.ResumeLayout(false);
			this.GRP_MotdPlugin_Motd_Body.PerformLayout();
			this.TAB_MotdPlugin.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ColumnHeader LST_Column_Advert;
		private System.Windows.Forms.ToolStripStatusLabel MotdConfig_Status;
		private System.Windows.Forms.StatusStrip StatusBar;
		private System.Windows.Forms.TabPage TAB_MotdPlugin_Advets_Page;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.SplitContainer splitContainer5;
		private System.Windows.Forms.GroupBox GRP_AdvertsConfig_Adverts;
		private System.Windows.Forms.ListView LST_AdvertsConfig_Adverts;
		private System.Windows.Forms.ColumnHeader LST_Adverts_Column_AdvertName;
		private System.Windows.Forms.ColumnHeader LST_Adverts_Column_AdvertTime;
		private System.Windows.Forms.ColumnHeader LST_Adverts_Column_AdvertText;
		private System.Windows.Forms.GroupBox GRP_AdvertsConfig_Selected_New;
		private System.Windows.Forms.Button BTN_MotdPlugin_Adverts_DeleteAdvert;
		private System.Windows.Forms.Button BTN_MotdPlugin_Adverts_New;
		private System.Windows.Forms.TextBox TXT_MotdPlugin_Adverts_Text;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown NUM_MotdPlugin_Adverts_Time;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TXT_MotdPlugin_Adverts_Name;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TabPage TAB_MotdPlugin_Motd_Page;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.GroupBox GRP_MotdPlugin_Motd_Title;
		private System.Windows.Forms.TextBox TXT_MotdPlugin_Motd_Title;
		private System.Windows.Forms.GroupBox GRP_MotdPlugin_Motd_Body;
		private System.Windows.Forms.TextBox TXT_MotdPlugin_Motd_Body;
		private System.Windows.Forms.Button BTN_MotdPlugin_Motd_Save;
		private System.Windows.Forms.CheckBox CHK_MotdPlugin_Motd_Active;
		private System.Windows.Forms.TabControl TAB_MotdPlugin;
		private System.Windows.Forms.CheckBox CHK_MotdPlugin_Adverts_Active;
		private System.Windows.Forms.Button BTN_MotdPlugin_Adverts_Update;
		private System.Windows.Forms.CheckBox CHK_MotdPlugin_Adverts_EnableAdvert;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.WebBrowser webBrowser2;

	}
}
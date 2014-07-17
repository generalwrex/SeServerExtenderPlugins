namespace UserManagmentPlugin
{
	partial class UserManagmentForm
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
			this.BTN_UserManagment_AddUser = new System.Windows.Forms.Button();
			this.LST_UserManagement_Users = new System.Windows.Forms.ListView();
			this.LST_UserManagement_ConnectedPlayers = new System.Windows.Forms.ListView();
			this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.IdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// BTN_UserManagment_AddUser
			// 
			this.BTN_UserManagment_AddUser.Location = new System.Drawing.Point(6, 249);
			this.BTN_UserManagment_AddUser.Name = "BTN_UserManagment_AddUser";
			this.BTN_UserManagment_AddUser.Size = new System.Drawing.Size(270, 28);
			this.BTN_UserManagment_AddUser.TabIndex = 0;
			this.BTN_UserManagment_AddUser.Text = "Add Player(s) ";
			this.BTN_UserManagment_AddUser.UseVisualStyleBackColor = true;
			this.BTN_UserManagment_AddUser.Click += new System.EventHandler(this.BTN_UserManagment_AddUser_Click);
			// 
			// LST_UserManagement_Users
			// 
			this.LST_UserManagement_Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.LST_UserManagement_Users.Location = new System.Drawing.Point(6, 19);
			this.LST_UserManagement_Users.Name = "LST_UserManagement_Users";
			this.LST_UserManagement_Users.Size = new System.Drawing.Size(300, 224);
			this.LST_UserManagement_Users.TabIndex = 2;
			this.LST_UserManagement_Users.UseCompatibleStateImageBehavior = false;
			this.LST_UserManagement_Users.View = System.Windows.Forms.View.Details;
			// 
			// LST_UserManagement_ConnectedPlayers
			// 
			this.LST_UserManagement_ConnectedPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.IdHeader});
			this.LST_UserManagement_ConnectedPlayers.Location = new System.Drawing.Point(6, 19);
			this.LST_UserManagement_ConnectedPlayers.Name = "LST_UserManagement_ConnectedPlayers";
			this.LST_UserManagement_ConnectedPlayers.Size = new System.Drawing.Size(270, 224);
			this.LST_UserManagement_ConnectedPlayers.TabIndex = 3;
			this.LST_UserManagement_ConnectedPlayers.UseCompatibleStateImageBehavior = false;
			this.LST_UserManagement_ConnectedPlayers.View = System.Windows.Forms.View.Details;
			this.LST_UserManagement_ConnectedPlayers.DoubleClick += new System.EventHandler(this.LST_UserManagement_ConnectedPlayers_DoubleClick);
			// 
			// NameHeader
			// 
			this.NameHeader.Text = "Name";
			// 
			// IdHeader
			// 
			this.IdHeader.Text = "ID";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 86;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "ID";
			this.columnHeader2.Width = 105;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Current Rank";
			this.columnHeader3.Width = 97;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.LST_UserManagement_ConnectedPlayers);
			this.groupBox1.Controls.Add(this.BTN_UserManagment_AddUser);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(282, 283);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Connected Users";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.LST_UserManagement_Users);
			this.groupBox2.Location = new System.Drawing.Point(300, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(312, 283);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "User List";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 249);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(106, 28);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(194, 249);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 28);
			this.button2.TabIndex = 4;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// UserManagmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(890, 576);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "UserManagmentForm";
			this.Text = "SeServerExtender User Managment";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BTN_UserManagment_AddUser;
		private System.Windows.Forms.ListView LST_UserManagement_Users;
		private System.Windows.Forms.ListView LST_UserManagement_ConnectedPlayers;
		private System.Windows.Forms.ColumnHeader NameHeader;
		private System.Windows.Forms.ColumnHeader IdHeader;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;

	}
}
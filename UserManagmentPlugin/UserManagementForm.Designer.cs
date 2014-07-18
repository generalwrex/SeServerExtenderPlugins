namespace UserManagmentPlugin
{
	partial class UserManagementForm
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
			this.TAB_UserManagment = new System.Windows.Forms.TabControl();
			this.TAB_Users_Page = new System.Windows.Forms.TabPage();
			this.TAB_Ranks_Page = new System.Windows.Forms.TabPage();
			this.TAB_UserManagment.SuspendLayout();
			this.SuspendLayout();
			// 
			// TAB_UserManagment
			// 
			this.TAB_UserManagment.Controls.Add(this.TAB_Users_Page);
			this.TAB_UserManagment.Controls.Add(this.TAB_Ranks_Page);
			this.TAB_UserManagment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TAB_UserManagment.Location = new System.Drawing.Point(0, 0);
			this.TAB_UserManagment.Name = "TAB_UserManagment";
			this.TAB_UserManagment.SelectedIndex = 0;
			this.TAB_UserManagment.Size = new System.Drawing.Size(630, 576);
			this.TAB_UserManagment.TabIndex = 0;
			// 
			// TAB_Users_Page
			// 
			this.TAB_Users_Page.Location = new System.Drawing.Point(4, 22);
			this.TAB_Users_Page.Name = "TAB_Users_Page";
			this.TAB_Users_Page.Padding = new System.Windows.Forms.Padding(3);
			this.TAB_Users_Page.Size = new System.Drawing.Size(622, 550);
			this.TAB_Users_Page.TabIndex = 0;
			this.TAB_Users_Page.Text = "Users";
			this.TAB_Users_Page.UseVisualStyleBackColor = true;
			// 
			// TAB_Ranks_Page
			// 
			this.TAB_Ranks_Page.Location = new System.Drawing.Point(4, 22);
			this.TAB_Ranks_Page.Name = "TAB_Ranks_Page";
			this.TAB_Ranks_Page.Padding = new System.Windows.Forms.Padding(3);
			this.TAB_Ranks_Page.Size = new System.Drawing.Size(622, 550);
			this.TAB_Ranks_Page.TabIndex = 1;
			this.TAB_Ranks_Page.Text = "Ranks";
			this.TAB_Ranks_Page.UseVisualStyleBackColor = true;
			// 
			// UserManagementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 576);
			this.Controls.Add(this.TAB_UserManagment);
			this.Name = "UserManagementForm";
			this.Text = "SeServerExtender User Managment";
			this.TAB_UserManagment.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TAB_UserManagment;
		private System.Windows.Forms.TabPage TAB_Users_Page;
		private System.Windows.Forms.TabPage TAB_Ranks_Page;


	}
}
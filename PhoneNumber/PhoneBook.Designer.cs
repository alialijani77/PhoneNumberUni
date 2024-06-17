namespace PhoneNumber
{
	partial class PhoneBook
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
			menuStrip1 = new MenuStrip();
			افزودنشخصجدیدToolStripMenuItem = new ToolStripMenuItem();
			btnadduser = new ToolStripMenuItem();
			بروزرسانیToolStripMenuItem = new ToolStripMenuItem();
			تغییررمزعبورToolStripMenuItem = new ToolStripMenuItem();
			dataGridView1 = new DataGridView();
			LastNsme = new DataGridViewTextBoxColumn();
			UserName = new DataGridViewTextBoxColumn();
			Sex = new DataGridViewTextBoxColumn();
			Birthday = new DataGridViewTextBoxColumn();
			Mobile = new DataGridViewTextBoxColumn();
			Email = new DataGridViewTextBoxColumn();
			UserId = new DataGridViewTextBoxColumn();
			button1 = new Button();
			button2 = new Button();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { افزودنشخصجدیدToolStripMenuItem, btnadduser, بروزرسانیToolStripMenuItem, تغییررمزعبورToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(861, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// افزودنشخصجدیدToolStripMenuItem
			// 
			افزودنشخصجدیدToolStripMenuItem.Name = "افزودنشخصجدیدToolStripMenuItem";
			افزودنشخصجدیدToolStripMenuItem.Size = new Size(146, 24);
			افزودنشخصجدیدToolStripMenuItem.Text = "افزودن شخص جدید";
			افزودنشخصجدیدToolStripMenuItem.Click += افزودنشخصجدیدToolStripMenuItem_Click;
			// 
			// btnadduser
			// 
			btnadduser.Name = "btnadduser";
			btnadduser.Size = new Size(133, 24);
			btnadduser.Text = "افزودن کاربر جدید";
			btnadduser.Click += افزودنکاربرجدیدToolStripMenuItem_Click;
			// 
			// بروزرسانیToolStripMenuItem
			// 
			بروزرسانیToolStripMenuItem.Name = "بروزرسانیToolStripMenuItem";
			بروزرسانیToolStripMenuItem.Size = new Size(86, 24);
			بروزرسانیToolStripMenuItem.Text = "بروزرسانی";
			بروزرسانیToolStripMenuItem.Click += بروزرسانیToolStripMenuItem_Click;
			// 
			// تغییررمزعبورToolStripMenuItem
			// 
			تغییررمزعبورToolStripMenuItem.Name = "تغییررمزعبورToolStripMenuItem";
			تغییررمزعبورToolStripMenuItem.Size = new Size(104, 24);
			تغییررمزعبورToolStripMenuItem.Text = "تغییر رمزعبور";
			تغییررمزعبورToolStripMenuItem.Click += تغییررمزعبورToolStripMenuItem_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { LastNsme, UserName, Sex, Birthday, Mobile, Email, UserId });
			dataGridView1.Location = new Point(0, 51);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(861, 244);
			dataGridView1.TabIndex = 1;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// LastNsme
			// 
			LastNsme.DataPropertyName = "FullFamily";
			LastNsme.HeaderText = "نام خانوادگی";
			LastNsme.MinimumWidth = 6;
			LastNsme.Name = "LastNsme";
			LastNsme.ReadOnly = true;
			LastNsme.Width = 125;
			// 
			// UserName
			// 
			UserName.DataPropertyName = "UserName";
			UserName.HeaderText = "نام کاربری";
			UserName.MinimumWidth = 6;
			UserName.Name = "UserName";
			UserName.ReadOnly = true;
			UserName.Width = 125;
			// 
			// Sex
			// 
			Sex.DataPropertyName = "Sex";
			Sex.HeaderText = "جنسیت";
			Sex.MinimumWidth = 6;
			Sex.Name = "Sex";
			Sex.ReadOnly = true;
			Sex.Width = 125;
			// 
			// Birthday
			// 
			Birthday.DataPropertyName = "Birthday";
			Birthday.HeaderText = "تاریخ تولد";
			Birthday.MinimumWidth = 6;
			Birthday.Name = "Birthday";
			Birthday.ReadOnly = true;
			Birthday.Width = 125;
			// 
			// Mobile
			// 
			Mobile.DataPropertyName = "Mobile";
			Mobile.HeaderText = "موبایل";
			Mobile.MinimumWidth = 6;
			Mobile.Name = "Mobile";
			Mobile.ReadOnly = true;
			Mobile.Width = 125;
			// 
			// Email
			// 
			Email.DataPropertyName = "Email";
			Email.HeaderText = "ایمیل";
			Email.MinimumWidth = 6;
			Email.Name = "Email";
			Email.ReadOnly = true;
			Email.Width = 180;
			// 
			// UserId
			// 
			UserId.DataPropertyName = "UserId";
			UserId.HeaderText = "شناسه کاربری";
			UserId.MinimumWidth = 6;
			UserId.Name = "UserId";
			UserId.ReadOnly = true;
			UserId.Width = 125;
			// 
			// button1
			// 
			button1.Location = new Point(744, 330);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 2;
			button1.Text = "ویرایش";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(644, 330);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 3;
			button2.Text = "حذف";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// PhoneBook
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(861, 375);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Controls.Add(menuStrip1);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			MainMenuStrip = menuStrip1;
			Name = "PhoneBook";
			RightToLeft = RightToLeft.Yes;
			Text = "دفترچه تلفن من";
			Load += PhoneBook_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem افزودنشخصجدیدToolStripMenuItem;
		private ToolStripMenuItem btnadduser;
		private ToolStripMenuItem بروزرسانیToolStripMenuItem;
		private ToolStripMenuItem تغییررمزعبورToolStripMenuItem;
		private DataGridView dataGridView1;
		private Button button1;
		private Button button2;
		private DataGridViewTextBoxColumn LastNsme;
		private DataGridViewTextBoxColumn UserName;
		private DataGridViewTextBoxColumn Sex;
		private DataGridViewTextBoxColumn Birthday;
		private DataGridViewTextBoxColumn Mobile;
		private DataGridViewTextBoxColumn Email;
		private DataGridViewTextBoxColumn UserId;
	}
}
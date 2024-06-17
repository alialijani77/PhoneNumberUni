namespace PhoneNumber
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			btnLogin = new Button();
			btnCancel = new Button();
			txtUserName = new TextBox();
			txtPassword = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(29, 35);
			label1.Name = "label1";
			label1.Size = new Size(77, 20);
			label1.TabIndex = 0;
			label1.Text = "نام کاربری :";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(29, 93);
			label2.Name = "label2";
			label2.Size = new Size(68, 20);
			label2.TabIndex = 1;
			label2.Text = "رمز عبور :";
			label2.Click += label2_Click;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(202, 147);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(94, 29);
			btnLogin.TabIndex = 2;
			btnLogin.Text = "ورود";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(318, 147);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(94, 29);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "انصراف";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(130, 32);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(282, 27);
			txtUserName.TabIndex = 4;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(130, 90);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(282, 27);
			txtPassword.TabIndex = 5;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(714, 200);
			Controls.Add(txtPassword);
			Controls.Add(txtUserName);
			Controls.Add(btnCancel);
			Controls.Add(btnLogin);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Name = "Form1";
			RightToLeft = RightToLeft.Yes;
			RightToLeftLayout = true;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "نرم افزار دفترچه تلفن";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Button btnLogin;
		private Button btnCancel;
		private TextBox txtUserName;
		private TextBox txtPassword;
	}
}

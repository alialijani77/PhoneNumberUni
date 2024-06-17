namespace PhoneNumber
{
	partial class ForgotPassword
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(22, 57);
			label1.Name = "label1";
			label1.Size = new Size(117, 20);
			label1.TabIndex = 0;
			label1.Text = "کلمه عبور فعلی :";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(22, 118);
			label2.Name = "label2";
			label2.Size = new Size(112, 20);
			label2.TabIndex = 1;
			label2.Text = "کلمه عبور جدید :";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 177);
			label3.Name = "label3";
			label3.Size = new Size(144, 20);
			label3.TabIndex = 2;
			label3.Text = "تکرار کلمه عبور جدید :";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(192, 54);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(230, 27);
			textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(192, 118);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(230, 27);
			textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(192, 177);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(230, 27);
			textBox3.TabIndex = 5;
			// 
			// button1
			// 
			button1.Location = new Point(232, 236);
			button1.Name = "button1";
			button1.Size = new Size(146, 29);
			button1.TabIndex = 6;
			button1.Text = "تغییر کلمه عبور";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// ForgotPassword
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(460, 295);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "ForgotPassword";
			RightToLeft = RightToLeft.Yes;
			RightToLeftLayout = true;
			Text = "ForgotPassword";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private Button button1;
	}
}
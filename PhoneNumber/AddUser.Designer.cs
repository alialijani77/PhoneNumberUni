namespace PhoneNumber
{
	partial class AddUser
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
			textBox1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			textBox5 = new TextBox();
			button1 = new Button();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			textBox6 = new TextBox();
			textBox7 = new TextBox();
			textBox8 = new TextBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(167, 54);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(273, 27);
			textBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 57);
			label1.Name = "label1";
			label1.Size = new Size(77, 20);
			label1.TabIndex = 1;
			label1.Text = "نام کاربری :";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 177);
			label2.Name = "label2";
			label2.Size = new Size(49, 20);
			label2.TabIndex = 2;
			label2.Text = "ایمیل :";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 140);
			label3.Name = "label3";
			label3.Size = new Size(62, 20);
			label3.TabIndex = 3;
			label3.Text = "جنسیت :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 99);
			label4.Name = "label4";
			label4.Size = new Size(131, 20);
			label4.TabIndex = 4;
			label4.Text = "نام و نام خانوادگی :";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 221);
			label5.Name = "label5";
			label5.Size = new Size(78, 20);
			label5.TabIndex = 5;
			label5.Text = "کلمه عبور :";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(167, 99);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(273, 27);
			textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(167, 137);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(273, 27);
			textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(167, 177);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(273, 27);
			textBox4.TabIndex = 8;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(167, 221);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(273, 27);
			textBox5.TabIndex = 9;
			// 
			// button1
			// 
			button1.Location = new Point(198, 395);
			button1.Name = "button1";
			button1.Size = new Size(199, 29);
			button1.TabIndex = 10;
			button1.Text = "ثبت";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 263);
			label6.Name = "label6";
			label6.Size = new Size(100, 20);
			label6.TabIndex = 11;
			label6.Text = "شماره موبایل :";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(12, 305);
			label7.Name = "label7";
			label7.Size = new Size(63, 20);
			label7.TabIndex = 12;
			label7.Text = "کد ملی :";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(12, 344);
			label8.Name = "label8";
			label8.Size = new Size(47, 20);
			label8.TabIndex = 13;
			label8.Text = "نقش :";
			// 
			// textBox6
			// 
			textBox6.Location = new Point(167, 263);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(273, 27);
			textBox6.TabIndex = 14;
			// 
			// textBox7
			// 
			textBox7.Location = new Point(167, 305);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(273, 27);
			textBox7.TabIndex = 15;
			// 
			// textBox8
			// 
			textBox8.Location = new Point(167, 352);
			textBox8.Name = "textBox8";
			textBox8.Size = new Size(273, 27);
			textBox8.TabIndex = 16;
			// 
			// AddUser
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(508, 457);
			Controls.Add(textBox8);
			Controls.Add(textBox7);
			Controls.Add(textBox6);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(button1);
			Controls.Add(textBox5);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Name = "AddUser";
			RightToLeft = RightToLeft.Yes;
			RightToLeftLayout = true;
			Text = "AddUser";
			Load += AddUser_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox5;
		private Button button1;
		private Label label6;
		private Label label7;
		private Label label8;
		private TextBox textBox6;
		private TextBox textBox7;
		private TextBox textBox8;
	}
}
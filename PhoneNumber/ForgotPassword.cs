using PhoneNumber.Data.Convertor;
using PhoneNumber.Data.Services;

namespace PhoneNumber
{
	public partial class ForgotPassword : Form
	{
		public ForgotPassword()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var userService = new UserService();
			if ((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty) || (textBox3.Text == string.Empty))
			{
				MessageBox.Show("Please Enter Password");
				return;
			}
			var user = userService.GetUserByPassword(PasswordHelper.EncodePasswordMd5(textBox1.Text));
			if (user == null)
			{
				MessageBox.Show("User Not Found");
				return;
			}
			user.Password = PasswordHelper.EncodePasswordMd5(textBox2.Text);

			userService.UpdateUser(user);
			this.Close();

		}
	}
}

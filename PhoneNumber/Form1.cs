using PhoneNumber.Data.Convertor;
using PhoneNumber.Data.Services;

namespace PhoneNumber
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var userService = new UserService();
			if ((txtUserName.Text == string.Empty) || (txtPassword.Text == string.Empty))
			{
				MessageBox.Show("Please Enter UserName Or Password");
				return;
			}
			var user = userService.GetUserByUserNamePassword(txtUserName.Text, PasswordHelper.EncodePasswordMd5(txtPassword.Text));
			if (user == null)
			{
				MessageBox.Show("User Not Found");
				return;
			}
			PhoneBook phoneBook = new PhoneBook();
			phoneBook.Show();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

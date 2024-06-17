using PhoneNumber.Data.Convertor;
using PhoneNumber.Data.DTOs;
using PhoneNumber.Data.Services;

namespace PhoneNumber
{
	public partial class AddUser : Form
	{

		public AddUser()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			PhoneNumber.Data.Services.UserService _service = new UserService();
			UserViewModel userViewModel = new UserViewModel();
			userViewModel.UserName = textBox1.Text;
			userViewModel.FullFamily = textBox2.Text;
			userViewModel.Sex = textBox3.Text;
			userViewModel.Email = textBox4.Text;
			userViewModel.Password = PasswordHelper.EncodePasswordMd5(textBox5.Text);
			userViewModel.Mobile = textBox6.Text;
			userViewModel.NationalId = textBox7.Text;
			userViewModel.RoleId = Convert.ToInt16(textBox8.Text);

			_service.AddUser(userViewModel);
			this.Close();


		}

		private void AddUser_Load(object sender, EventArgs e)
		{

		}
	}
}

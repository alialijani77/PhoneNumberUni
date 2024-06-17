using PhoneNumber.Data.Entities.User;
using PhoneNumber.Data.Services;

namespace PhoneNumber
{
	public partial class UpdatePeople : Form
	{
		People _people;
		public UpdatePeople(People people)
		{
			InitializeComponent();
			_people = people;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			PeopleService people = new PeopleService();
			_people.UserName = textBox1.Text;
			_people.FullFamily = textBox2.Text;
			_people.Sex = textBox3.Text;
			_people.Email = textBox4.Text;
			_people.Mobile = textBox6.Text;
			people.UpdatePeople(_people);
			this.Close();

		}

		private void UpdatePeople_Load(object sender, EventArgs e)
		{
			textBox1.Text = _people.UserName;
			textBox2.Text = _people.FullFamily;
			textBox3.Text = _people.Sex;
			textBox4.Text = _people.Email;
			textBox6.Text = _people.Mobile;
		}
	}
}

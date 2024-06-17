using PhoneNumber.Data.DTOs;
using PhoneNumber.Data.Services;

namespace PhoneNumber
{
	public partial class AddPeople : Form
	{
		public AddPeople()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			PeopleService peopleService = new PeopleService();

			var people = new PeopleViewModel();
			people.UserName = textBox1.Text;
			people.FullFamily = textBox2.Text;
			people.Sex = textBox3.Text;
			people.Email = textBox4.Text;
			people.Mobile = textBox6.Text;
			people.BirthDay = dateTimePicker1.Value;

			peopleService.AddPeople(people);
			this.Close();

		}
	}
}

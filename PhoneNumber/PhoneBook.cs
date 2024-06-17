using PhoneNumber.Data.DTOs;
using PhoneNumber.Data.Services;

namespace PhoneNumber
{
	public partial class PhoneBook : Form
	{

		public PhoneBook()
		{
			InitializeComponent();

		}

		private void افزودنکاربرجدیدToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PhoneNumber.AddUser userForm = new PhoneNumber.AddUser();
			userForm.ShowDialog();
		}

		private void افزودنشخصجدیدToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PhoneNumber.AddPeople userForm = new PhoneNumber.AddPeople();
			userForm.ShowDialog();
		}

		private void بروزرسانیToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PeopleService peopleService = new PeopleService();

			var users = peopleService.GetUsers();
			this.dataGridView1.DataSource = users;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void PhoneBook_Load(object sender, EventArgs e)
		{
			PeopleService peopleService = new PeopleService();

			var users = peopleService.GetUsers();
			this.dataGridView1.DataSource = users;

			foreach (var user in users)
			{
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int userId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
			PeopleService people = new PeopleService();
			var p = people.GetPeople(userId);
			PhoneNumber.UpdatePeople userForm = new PhoneNumber.UpdatePeople(p);
			userForm.ShowDialog();

			PeopleViewModel viewModel = new PeopleViewModel();

			viewModel.UserId = userId;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			int userId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
			PeopleService people = new PeopleService();
			var p = people.GetPeople(userId);
			people.Delete(p);
		}

		private void تغییررمزعبورToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PhoneNumber.ForgotPassword userForm = new PhoneNumber.ForgotPassword();
			userForm.ShowDialog();
		}
	}
}


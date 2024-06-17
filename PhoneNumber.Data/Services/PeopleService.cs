using PhoneNumber.Data.Context;
using PhoneNumber.Data.DTOs;
using PhoneNumber.Data.Entities.User;
using PhoneNumber.Data.Repository;

namespace PhoneNumber.Data.Services
{
	public class PeopleService : IPeople
	{
		public async void AddPeople(PeopleViewModel peopleViewModel)
		{
			MyDbContext myDbContext = new MyDbContext();

			var people = new People();

			people.UserName = peopleViewModel.UserName;
			people.FullFamily = peopleViewModel.FullFamily;
			people.Mobile = peopleViewModel.Mobile;
			people.Email = peopleViewModel.Email;
			people.Sex = peopleViewModel.Sex;

			await myDbContext.Peoples.AddAsync(people);
			myDbContext.SaveChanges();
		}

		public List<PeopleViewModel> GetUsers()
		{
			MyDbContext MyDbContext = new MyDbContext();

			List<PeopleViewModel> userViewModels = new List<PeopleViewModel>();
			var users = MyDbContext.Peoples.Select(x => new PeopleViewModel()
			{
				UserId = x.UserId,
				BirthDay = x.BirthDay,
				Sex = x.Sex,
				Email = x.Email,
				FullFamily = x.FullFamily,
				Mobile = x.Mobile,
				UserName = x.UserName,
			});

			foreach (var user in users)
			{
				user.BirthDay = user.BirthDay;
				userViewModels.Add(user);
			}
			return userViewModels.ToList();
		}

		public void UpdatePeople(People p)
		{
			MyDbContext myDbContext = new MyDbContext();


			myDbContext.Peoples.Update(p);
			myDbContext.SaveChanges();
		}

		public People GetPeople(int userId)
		{
			MyDbContext myDbContext = new MyDbContext();

			var people = myDbContext.Peoples.Find(userId);

			return people;

		}

		public void Delete(People p)
		{
			MyDbContext myDbContext = new MyDbContext();
			myDbContext.Peoples.Remove(p);
			myDbContext.SaveChanges();
		}
	}
}

using PhoneNumber.Data.Context;
using PhoneNumber.Data.DTOs;
using PhoneNumber.Data.Entities.User;
using PhoneNumber.Data.Repository;

namespace PhoneNumber.Data.Services
{
	public class UserService : IUser
	{
		public void AddUser(UserViewModel userViewModel)
		{
			MyDbContext MyDbContext = new MyDbContext();

			var user = new User();
			user.UserName = userViewModel.UserName;
			user.Email = userViewModel.Email;
			user.BirthDay = userViewModel.BirthDay;
			user.UserAvatar = userViewModel.UserAvatar;
			user.Password = userViewModel.Password;
			user.FullFamily = userViewModel.FullFamily;
			user.Mobile = userViewModel.Mobile;
			user.NationalId = userViewModel.NationalId;
			user.RoleId = userViewModel.RoleId;
			user.Sex = userViewModel.Sex;
			user.UserAvatar = "null";

			MyDbContext.Users.AddAsync(user);
			MyDbContext.SaveChanges();
		}

		public UserViewModel GetUserByUserNamePassword(string userName, string password)
		{
			MyDbContext MyDbContext = new MyDbContext();

			var user = MyDbContext.Users.FirstOrDefault(x => x.UserName == userName && x.Password == password);
			if (user == null)
			{
				return null;
			}
			var userViewModel = new UserViewModel();
			userViewModel.UserName = user?.UserName;
			userViewModel.FullFamily = user.FullFamily;
			userViewModel.Mobile = user.Mobile;
			userViewModel.BirthDay = user.BirthDay;
			userViewModel.Sex = user.Sex;
			return userViewModel;
		}

		public UserViewModel GetUserByPassword(string password)
		{
			MyDbContext MyDbContext = new MyDbContext();

			var user = MyDbContext.Users.FirstOrDefault(x => x.Password == password);
			if (user == null)
			{
				return null;
			}
			var userViewModel = new UserViewModel();
			userViewModel.UserName = user?.UserName;
			userViewModel.FullFamily = user.FullFamily;
			userViewModel.Mobile = user.Mobile;
			userViewModel.BirthDay = user.BirthDay;
			userViewModel.Sex = user.Sex;
			return userViewModel;
		}

		public void UpdateUser(UserViewModel userViewModel)
		{
			MyDbContext MyDbContext = new MyDbContext();

			var user = MyDbContext.Users.FirstOrDefault(x => x.UserName == userViewModel.UserName && x.Password == userViewModel.Password);

			user.UserName = userViewModel.UserName;
			user.FullFamily = userViewModel.FullFamily;
			userViewModel.Mobile = userViewModel.Mobile;
			user.BirthDay = userViewModel.BirthDay;
			user.Sex = userViewModel.Sex;

			MyDbContext.Users.Update(user);
			MyDbContext.SaveChanges();
		}
	}
}

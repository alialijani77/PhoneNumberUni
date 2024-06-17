using PhoneNumber.Data.DTOs;

namespace PhoneNumber.Data.Repository
{
	public interface IUser
	{
		void AddUser(UserViewModel userViewModel);

		UserViewModel GetUserByUserNamePassword(string userName, string password);

		UserViewModel GetUserByPassword(string password);

		void UpdateUser(UserViewModel userViewModel);
	}
}

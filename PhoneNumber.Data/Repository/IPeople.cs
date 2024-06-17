using PhoneNumber.Data.DTOs;
using PhoneNumber.Data.Entities.User;

namespace PhoneNumber.Data.Repository
{
	public interface IPeople
	{
		void AddPeople(PeopleViewModel peopleViewModel);

		List<PeopleViewModel> GetUsers();

		void UpdatePeople(People p);
	}
}

using System.ComponentModel.DataAnnotations;

namespace PhoneNumber.Data.Entities.User
{
	public class Role
	{
		public Role()
		{

		}
		[Key]
		public int RoleId { get; set; }
		public string RoleTitle { get; set; }
		public bool IsDelete { get; set; }

		public virtual ICollection<User> Users { get; set; }
	}
}

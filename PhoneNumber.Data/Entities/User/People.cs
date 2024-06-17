using System.ComponentModel.DataAnnotations;

namespace PhoneNumber.Data.Entities.User
{
	public class People
	{
		public People()
		{

		}
		[Key]
		public int UserId { get; set; }

		[Display(Name = "نام کاربری")]
		[MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string UserName { get; set; }
		[Display(Name = "نام و نام خانوادگی")]
		public string FullFamily { get; set; }
		[Display(Name = "جنسیت")]
		public string Sex { get; set; }
		[Display(Name = "تاریخ تولد")]
		[MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		public DateTime BirthDay { get; set; }
		[Display(Name = "شماره همراه")]
		[MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]

		public string Mobile { get; set; }
		[Display(Name = "ایمیل")]
		[MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]

		public string Email { get; set; }
	
	}
}

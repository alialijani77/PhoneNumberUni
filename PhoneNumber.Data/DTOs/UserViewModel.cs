using System.ComponentModel.DataAnnotations;

namespace PhoneNumber.Data.DTOs
{
	public class UserViewModel
	{
		[Display(Name = "نام کاربری")]
		[MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string UserName { get; set; }
		[Display(Name = "نام و نام خانوادگی")]
		public string FullFamily { get; set; }
		[Display(Name = "جنسیت")]
		public string Sex { get; set; }
		[Display(Name = "کد ملی")]
		[MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		public string NationalId { get; set; }
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
		[Display(Name = "کلمه عبور")]
		[MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]

		public string Password { get; set; }
		[Display(Name = "آواتار")]
		[MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
		public string UserAvatar { get; set; }
		public int RoleId { get; set; }

	}
}

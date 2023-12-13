using System.ComponentModel.DataAnnotations;

namespace MarkBook.Data.Login
{
	public class LoginModel
	{
		[Required]
		[MaxLength(20, ErrorMessage = "Логин слишком длинный!")]
		public string Login { get; set; }

		[Required]
		[MaxLength(30, ErrorMessage = "Пароль слишком длинный!")]
		public string Password { get; set; }
	}
}

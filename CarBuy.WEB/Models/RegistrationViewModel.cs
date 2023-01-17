using System.ComponentModel.DataAnnotations;

namespace CarBuy.WEB.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "Не указан Логин")]
        public string UserName { get; set; }
 
        [Required(ErrorMessage = "Не указан Пароль")]
        [UIHint("passowrd")]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Не указан номер телефона")]
        public string PhoneNumber { get; set; }
    }
      
}

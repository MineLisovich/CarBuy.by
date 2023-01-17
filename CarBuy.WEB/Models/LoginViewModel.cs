using System.ComponentModel.DataAnnotations;

namespace CarBuy.WEB.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Не указан Логин")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Не указан Пароль")]
        [UIHint("password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace CarBuy.WEB.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

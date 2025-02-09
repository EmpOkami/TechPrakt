using System.ComponentModel.DataAnnotations;
namespace TechPrakt.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Ім'я")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        [Display(Name = "Підтвердження пароля")]
        public string ConfirmPassword { get; set; }
    }
}

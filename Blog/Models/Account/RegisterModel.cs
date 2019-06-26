using System.ComponentModel.DataAnnotations;

namespace Blog.Models.Account
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Вы не ввели свою почту")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Вы не ввели свой пароль")]
        [MinLength(6)]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}
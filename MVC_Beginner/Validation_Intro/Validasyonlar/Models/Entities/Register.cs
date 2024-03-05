using System.ComponentModel.DataAnnotations;

namespace Validasyonlar.Models.Entities
{
    public class Register
    {
        public string UserName { get; set; }
        public string Email { get; set; }


        [Required(ErrorMessage = "Şifre boş olamaz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı boş olamaz!")]
        [Compare("Password", ErrorMessage = "Parola ve parola tekrarı aynı olmalıdır!")]
        public string ConfirmPassword { get; set; }
    }
}

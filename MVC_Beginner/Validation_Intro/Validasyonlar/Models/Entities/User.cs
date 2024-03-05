using System.ComponentModel.DataAnnotations;
using Validasyonlar.ValidationClasses;

namespace Validasyonlar.Models.Entities
{
    public class User
    {
        [Key]
        [Range(1, int.MaxValue)]
        public int ID { get; set; }

        [UserNameValidation(ErrorMessage = "Kullanıcı Adı Uygunsuz")]
        [Required(ErrorMessage = "Kullanıcı adı boş olamaz!")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Kullanıcı adı en az 3, en fazla 25 karakter olmalıdır!")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [EmailValidation(ErrorMessage = "Email Uygunsuz")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Geçerli bir E-Mail adresi giriniz.")]
        [Required(ErrorMessage = "Email boş olamaz!")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [BirthDateValidation(ErrorMessage = "Doğum Tarihi Uygunsuz")]
        [DataType(DataType.Date, ErrorMessage = "Geçerli Bir Tarih Giriniz.")]
        [Required(ErrorMessage = "Doğum Tarihi boş olamaz!")]
        [Display(Name = "Doğum Tarihi")]
        public DateTime BirthDate { get; set; }

        [PasswordValidation(ErrorMessage = "Şifre Uygunsuz")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre boş olamaz!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Validasyonlar.Models.Entities
{
    public class Address
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Adres Girişi Zorunludur.")]
        [Display(Name ="Adres")]
        public string AddressLine { get; set; }

        [Required(ErrorMessage = "Şehir Girişi Zorunludur.")]
        [Display(Name = "Şehir")]
        public string City { get; set; }

        [Required(ErrorMessage = "Posta Kodu Girişi Zorunludur.")]
        [Display(Name = "Posta Kodu")]
        public int PostalCode { get; set; }
    }
}

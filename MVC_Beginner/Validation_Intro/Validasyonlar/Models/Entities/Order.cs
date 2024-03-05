using System.ComponentModel.DataAnnotations;

namespace Validasyonlar.Models.Entities
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Ürün adı boş olamaz!")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Kullanıcı adı en az 3, en fazla 25 karakter olmalıdır!")]
        [Display(Name = "Ürün Adı")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Adet boş olamaz!")]
        [Display(Name = "Adet")]
        [Range(0,int.MaxValue,ErrorMessage ="Adet En az 0 olmalıdır.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Fiyat boş olamaz!")]
        [Display(Name = "Fiyat")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Fiyat En az 0.01 olmalıdır.")]
        public double Price { get; set; }
    }
}

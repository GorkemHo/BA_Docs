using System.ComponentModel.DataAnnotations;

namespace Validasyonlar.ValidationClasses
{
    public class AddressValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return false;

            string adres = value as string;

            if(string.IsNullOrEmpty(adres)) return false;


            string[] sehirler = new string[] { "Ankara", "İstanbul", "İzmir" };
            adres = adres.Trim().ToLower();
            if (!sehirler.Contains(adres)) return false;
            
            return true;


           
        }
    }
}

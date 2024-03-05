using System.ComponentModel.DataAnnotations;

namespace Validasyonlar.ValidationClasses
{
    public class UserNameValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return false;

            string veri = value as string;

            if (veri == null) return false;

            if(veri.Contains("admin") || veri.Contains(" ")) return false;

            return true;

            return base.IsValid(value);
        }

    }
}

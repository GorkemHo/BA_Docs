using System.ComponentModel.DataAnnotations;

namespace Validasyonlar.ValidationClasses
{
    public class PasswordValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return false;

            string sifre = value as string;

            if (string.IsNullOrEmpty(sifre)) return false;

            if (sifre.Length != 6)
            {
                return false;
            }

            if (sifre.Count(char.IsUpper) < 1)
            {
                return false;
            }

            if (sifre.Count(char.IsLower) < 1)
            {
                return false;
            }

            if (sifre.Count(char.IsDigit) < 1)
            {
                return false;
            }

            if (sifre.Count(c => !char.IsLetterOrDigit(c)) < 1)
            {
                return false;
            }
            return true;
            // Gg1-as
           
        }
    }
}

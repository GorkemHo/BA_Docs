using System.ComponentModel.DataAnnotations;

namespace Validasyonlar.ValidationClasses
{
    public class EmailValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string kontrolEdilecekVeri;

            if (value == null)
            {
                return false;
            }

            kontrolEdilecekVeri = value.ToString();

            if (kontrolEdilecekVeri.Where(x => x == ' ').ToList().Count() > 0)
            {
                return false;
            }

            if (kontrolEdilecekVeri.Split('@').Count() > 2)
            {
                return false;
            }

            if (kontrolEdilecekVeri.EndsWith("@bilgeadam.com"))
            {
                return true;
            }
            return false;

        }
    }
}

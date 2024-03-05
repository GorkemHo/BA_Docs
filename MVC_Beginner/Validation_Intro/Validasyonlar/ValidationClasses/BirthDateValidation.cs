using System.ComponentModel.DataAnnotations;

namespace Validasyonlar.ValidationClasses
{
    public class BirthDateValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            DateTime? date = value as DateTime?;

            if (value == null) 
            { 
                return false; 
            }
            else
            {
                if (value.GetType() == typeof(DateTime))
                {
                    DateTime today = DateTime.Today;
                    int minAge = 18;
                    int maxAge = 100;
                    int age = today.Year - date.Value.Year;

                    if (age < minAge)
                    {
                        return false;
                    }
                    else if (age > maxAge)
                    {
                        return false;
                    }
                    return true;

                };
            }

            
            return false;

          
        }
    }
}

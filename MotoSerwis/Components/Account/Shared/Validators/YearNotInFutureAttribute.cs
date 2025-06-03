using System.ComponentModel.DataAnnotations;

namespace MotoSerwis.Components.Account.Shared.Validators
{
    public class YearNotInFutureAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is int year)
            {
                return year <= DateTime.Now.Year;
            }

            return true;
        }
    }
}

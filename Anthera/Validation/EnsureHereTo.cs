using Anthera_API.Data;
using Anthera_API.misc;
using DatabaseLookups;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Validation
{
    public class EnsureHereTo : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult(AntheraConstant.Errors.Requests.InvalidHereTo);
            }
            else if (!IsValid(value))
            {
                return new ValidationResult(AntheraConstant.Errors.Requests.InvalidHereTo);
            }
            return ValidationResult.Success;
        }

        public override bool IsValid(object value)
        {
            string strValue = value as string;
            foreach (var hereTo in DbInitializer.Values.hereTo)
            {
                if (hereTo.ToLower().Equals(strValue.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

    }
}

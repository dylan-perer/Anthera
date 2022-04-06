using Anthera_API.Data;
using Anthera_API.misc;
using DatabaseLookups;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Validation
{
    public class EnsureDrinking : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult(AntheraConstant.Errors.Requests.ChildrenIsRequired);
            }
            else if (!IsValid(value))
            {
                return new ValidationResult(AntheraConstant.Errors.Requests.InvalidChildren);
            }
            return ValidationResult.Success;
        }

        public override bool IsValid(object value)
        {
            string strValue = value as string;
            foreach (var drinking in DbInitializer.Values.drinking)
            {
                if (drinking.ToLower().Equals(strValue.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

    }
}

using Anthera_API.DataContext_NEW;
using Anthera_API.misc;

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
            foreach (var drinking in DbConstant.Drinking.AllDrinkingTypes)
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

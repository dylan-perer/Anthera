using Anthera_API.misc;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Validation
{
    public class EnsureGender : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null)
            {
                return new ValidationResult(ApiConstant.Errors.Requests.GenderIsRequired);
            }
            else if (!IsValid(value))
            {
                return new ValidationResult(ApiConstant.Errors.Requests.InvalidGender);
            }
            return ValidationResult.Success;
        }

        public override bool IsValid(object value)
        {
            string strValue = value as string;
            foreach (var gender in ApiConstant.Requests.ValidValues.User.GENDERS)
            {
                if (gender.ToLower().Equals(strValue.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

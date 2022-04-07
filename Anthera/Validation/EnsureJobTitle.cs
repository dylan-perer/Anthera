using Anthera_API.DELETE_Data;
using Anthera_API.misc;

using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Validation
{
    public class EnsureJobTitle : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult(AntheraConstant.Errors.Requests.JobTitleIsRequired);
            }
            else if (!IsValid(value))
            {
                return new ValidationResult(AntheraConstant.Errors.Requests.InvalidJobTitle);
            }
            return ValidationResult.Success;
        }

        public override bool IsValid(object value)
        {
            string strValue = value as string;
            foreach (var jobTitle in DbConstant.JobTitle.JobTitiles)
            {
                if (jobTitle.ToLower().Equals(strValue.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

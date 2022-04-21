using Anthera.API.Data;
using Anthera.API.misc;

using System.ComponentModel.DataAnnotations;

namespace Anthera.API.Validation
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
                if (jobTitle != null && jobTitle.ToLower().Equals(strValue.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

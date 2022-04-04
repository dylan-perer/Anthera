using Anthera_API.misc;
using DatabaseLookups;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Validation
{
    public class EnsureJobTitle : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null)
            {
                return new ValidationResult(ApiConstant.Errors.Requests.JobTitleIsRequired);
            }
            else if (!IsValid(value))
            {
                return new ValidationResult(ApiConstant.Errors.Requests.InvalidJobTitle);
            }
            return ValidationResult.Success;
        }

        public override bool IsValid(object value)
        {
            string strValue = value as string;
            foreach (var jobTitle in DbConstant.Values.jobTitle)
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

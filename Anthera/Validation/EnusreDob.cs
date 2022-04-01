using Anthera_API.misc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Validation
{
    public class EnusreDob : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult(ApiConstant.Errors.Requests.DobIsRequired);
            }
            try
            {
                var today = DateTime.UtcNow;
                var dob = DateTime.Parse(value.ToString());
                var oldestDob = DateTime.Now.AddYears(-99);
                if(oldestDob > dob)
                {
                    return new ValidationResult(ApiConstant.Errors.Requests.InvalidMaxDob);
                }
                if (dob <= DateTime.UtcNow.AddYears(-18))
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult(ApiConstant.Errors.Requests.InvalidMinDob);

            }
            catch (FormatException)
            {
                return new ValidationResult(ApiConstant.Errors.Requests.InvalidDate);
            }
        }

    }
}

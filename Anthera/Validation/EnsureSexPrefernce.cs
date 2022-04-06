using Anthera_API.Data;
using Anthera_API.misc;
using DatabaseLookups;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Validation
{
    public class EnsureSexPrefernce : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult(AntheraConstant.Errors.Requests.SexPreferenceRequired);
            }
            else if (!IsValid(value))
            {
                return new ValidationResult(AntheraConstant.Errors.Requests.InvalidSexPreference);
            }
            return ValidationResult.Success;
        }

        public override bool IsValid(object value)
        {
            string strValue = value as string;
            foreach (var sexPref in DbInitializer.Values.preferenceSex)
            {
                if (sexPref.ToLower().Equals(strValue.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

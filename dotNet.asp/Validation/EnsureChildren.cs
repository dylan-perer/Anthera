using Anthera.API.Data;
using Anthera.API.misc;

using System.ComponentModel.DataAnnotations;

namespace Anthera.API.Validation
{
    public class EnsureChildren : ValidationAttribute
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
            foreach ( var children in DbConstant.Children.AllChildrenTypes)
            {
                if (children !=null && children.ToLower().Equals(strValue.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

    }
}

﻿using Anthera_API.Data;
using Anthera_API.misc;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Anthera_API.Validation
{
    public class EnsureUniqueEmail : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var dataContext = (DataContext)validationContext.GetService(typeof(DataContext));

            if (value == null)
            {
                return new ValidationResult(ApiConstant.Errors.Requests.EmailAdressIsRequired);
            }
            var email = dataContext.User.FirstOrDefault(r => r.EmailAddress == value.ToString());
            return email == null ? ValidationResult.Success : new ValidationResult(ApiConstant.Errors.Requests.NonUniqueEmailAddress);
        }

    }
}
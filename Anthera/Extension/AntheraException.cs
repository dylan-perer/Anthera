using Anthera_API.misc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Anthera_API.Extension
{
    public class AntheraException
    {
        public bool IsInDevMode = true;

        public Exception Throw(string message, int statusCode = 400, bool isDevError = false, bool logToDb = false)
        {
            Exception e = new Exception();

            if (isDevError)
            {
                e.Data["DEV_ERROR"] = message;
            }
            else
            {
                e.Data["ERROR"] = message;
            }
            e.Data["STATUS_CODE"] = statusCode;
            return e;
        }

        public void Error(Exception ex, ILogger logger, string apiRoute, string actionName, string httpAction, object input, out int statusCode, out object msg )
        {
            statusCode = Int32.Parse(ex.Data["STATUS_CODE"].ToString());
            if (IsInDevMode)
            {
                if (ex.Data["DEV_ERROR"] != null)
                {
                    msg = new { errors = ex.Data["DEV_ERROR"] as string };
                    logger.LogError(CreateLog(ex, apiRoute, actionName, httpAction, input));
                    return;
                }
            }
            if (ex.Data["ERROR"] is null)
            {
                msg = new { errors = ApiConstant.Errors.GenericError };
                return;
            }
            msg = new { errors = ex.Data["ERROR"] as string };
        }

        private string CreateLog(Exception ex, string apiRoute, string actionName, string httpAction, object input=null)
        {
            return $"API_ROUTE:: {apiRoute}/{actionName} | HTTP_ACTION:: {httpAction} | USER_INPUT:: {input} | EXCEPTION:: {ex.Data["DEV_ERROR"].ToString()}";
        }
    }
}

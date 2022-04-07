using System;
namespace Anthera_API.DELETE_Data
{
    public class ErrorResult
    {
        public bool IsSuccess { get; set; } = true;
        public bool SendClientError { get; set; } = false;
        public string EndUserError { get; set; }
        public string Exception { get; set; }
        public string InnerException { get; set; }

        public void MapException(Exception ex)
        {
            IsSuccess = false;
            Exception = ex.Message;
            InnerException = ex.InnerException?.Message;
        }

        public string CreateLog(string apiRoute, string actionName, string httpAction, object input)
        {
            return $"API_ROUTE:: {apiRoute}/{actionName} | HTTP_ACTION:: {httpAction} | USER_INPUT:: {input} | EXCEPTION:: {Exception} | INNER_EXCEPTION:: {InnerException}";
        }

        public void SetEndUserError(string endUserErrors)
        {
            SendClientError = true;
            EndUserError = endUserErrors;
        }

        public object ReturnEndUserError()
        {
            return new { erorrs = EndUserError };
        }
    }
}

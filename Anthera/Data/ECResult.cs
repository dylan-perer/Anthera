using System;

namespace Anthera_API.Data
{
    public class ECResult
    {
        public bool IsSuccess { get; set; } = true;
        public string Exception { get; set; }
        public string InnerException { get; set; }
        public string[] EndUserError { get; set; }

        public void MapException(Exception ex)
        {
            IsSuccess = false;
            Exception = ex.Message;
            InnerException = ex.InnerException?.Message;
        }

    }
}

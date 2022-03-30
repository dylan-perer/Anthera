namespace Anthera_API.Data
{
    public class ECResult
    {
        public bool IsSuccess { get; set; }
        public string Exception { get; set; }
        public string InnerException { get; set; }
        public string[] EndUserError { get; set; }
    }
}

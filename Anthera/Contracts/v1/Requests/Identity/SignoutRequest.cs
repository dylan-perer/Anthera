namespace Anthera.API.Contracts.v1.Requests
{
    public class SignoutRequest
    {
        public string RefreshToken { get; set; }

        public override string ToString()
        {
            return $"RefreshToken: {RefreshToken}";
        }
    }

}

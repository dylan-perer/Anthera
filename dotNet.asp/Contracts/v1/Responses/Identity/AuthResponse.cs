namespace Anthera.API.Contracts.v1.Responses
{
    public class AuthResponse : IAuthResponse
    {

        public string AccessToken { set; get; }
        public string RefreshToken { set; get; }

        public string GetRefreshToken()
        {
            return RefreshToken;
        }

        public void SetTokens(string acessToken, string refreshToken)
        {
            AccessToken = acessToken;
            RefreshToken = refreshToken;
        }
    }
}

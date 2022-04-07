namespace Anthera_API.Contracts.v1.Responses
{
    public class AuthResponse : IAuthResponse
    {

        public string AccessToken { set; get; }
        public string RefrehToken { set; get; }

        public string GetRefreshToken()
        {
            return RefrehToken;
        }

        public void SetTokens(string acessToken, string refreshToken)
        {
            AccessToken = acessToken;
            RefrehToken = refreshToken;
        }
    }
}

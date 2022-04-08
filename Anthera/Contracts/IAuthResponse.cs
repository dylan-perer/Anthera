﻿namespace Anthera.API.Contracts
{
    public interface IAuthResponse
    {
        public void SetTokens(string accessToken, string refreshToken);
        public string GetRefreshToken();

    }
}

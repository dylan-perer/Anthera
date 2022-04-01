using System;

namespace Anthera_API.Contracts.v1.Responses
{
    public class AuthResponse : IAuthResponse
    {
        public string Token { set; get; }
        public DateTime CreatedAt { set; get; }
        public DateTime ExpireAt { set; get; }
        public string RefrehToken { set; get; }
        public DateTime RefreshTokencreatedAt { set; get; }
        public DateTime RefreshTokenexpireAt { set; get; }

        public void Map(string token, DateTime createdAt, DateTime expireAt, string refrehToken, DateTime refreshTokencreatedAt, DateTime refreshTokenexpireAt)
        {
            Token = token;
            CreatedAt = createdAt;
            ExpireAt = expireAt;
            RefrehToken = refrehToken;
            RefreshTokencreatedAt = refreshTokencreatedAt;
            RefreshTokenexpireAt = refreshTokenexpireAt;
        }
    }
}

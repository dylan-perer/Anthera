using System;

namespace Anthera_API.Contracts
{
    public interface IAuthResponse
    {
        public void Map(string Token, 
                        DateTime createdAt, 
                        DateTime expireAt, 
                        string refrehToken, 
                        DateTime refreshTokencreatedAt, 
                        DateTime refreshTokenexpireAt);
    }
}

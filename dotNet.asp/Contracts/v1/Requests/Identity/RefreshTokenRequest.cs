using System.ComponentModel.DataAnnotations;

namespace Anthera.API.Contracts.v1.Requests
{
    public class RefreshTokenRequest
    {
        [Required]
        public string RefreshToken { get; set; }

        public override string ToString()
        {
            return $"RefreshToken: {RefreshToken}";
        }
    }
}

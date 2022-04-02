using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class RefreshTokenRequest: Request
    {
        [Required]
        public string RefreshToken { get; set; }
    }
}

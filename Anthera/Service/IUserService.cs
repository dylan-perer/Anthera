using Anthera_API.Data;
using Anthera_API.Models;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Anthera_API.Service
{
    public interface IUserService
    {
        public void SetLogger(ILogger logger);
        public Task<(ECResult, User)> CreateAsync(User user);
        public Task<(ECResult, User)> UpdateByIdAsync(User user);
        
    }
}

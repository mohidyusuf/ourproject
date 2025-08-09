using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalApp.Services
{
    public interface ISocialReferencesService
    {
        Task CreateAsync(EntSocialReferences reference);
        Task<List<EntSocialReferences>> GetAllAsync();
        Task<EntSocialReferences?> GetByIdAsync(string id);
        Task UpdateAsync(string id, EntSocialReferences updated);
        Task DeleteAsync(string id);
    }
}

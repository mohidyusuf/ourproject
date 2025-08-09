using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalApp.Services
{
    public interface IShowroomProfileService
    {
        Task CreateAsync(EntShowroomProfile profile);
        Task<List<EntShowroomProfile>> GetAllAsync();
        Task<EntShowroomProfile?> GetByIdAsync(string id);
        Task UpdateAsync(string id, EntShowroomProfile updated);
        Task DeleteAsync(string id);
    }
}

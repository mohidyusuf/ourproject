using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalApp.Services
{
    public interface IShowroomAddressService
    {
        Task CreateAsync(EntShowroomAddress address);
        Task<List<EntShowroomAddress>> GetAllAsync();
        Task<EntShowroomAddress?> GetByIdAsync(string id);
        Task UpdateAsync(string id, EntShowroomAddress updated);
        Task DeleteAsync(string id);
    }
}

using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalApp.Services
{
    public interface IContactShowroomService
    {
        Task CreateAsync(EntContactShowroom contact);
        Task<List<EntContactShowroom>> GetAllAsync();
        Task<EntContactShowroom?> GetByIdAsync(string id);
        Task UpdateAsync(string id, EntContactShowroom updated);
        Task DeleteAsync(string id);
    }
}

using Dal;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CarRentalApp.Services
{
    public class ContactShowroomService : IContactShowroomService
    {

        public Task CreateAsync(EntContactShowroom contact) => DalContactShowroom.CreateAsync(contact);
        public Task<List<EntContactShowroom>> GetAllAsync() => DalContactShowroom.GetAllAsync();
        public Task<EntContactShowroom?> GetByIdAsync(string id) => DalContactShowroom.GetByIdAsync(id);
        public Task UpdateAsync(string id, EntContactShowroom updated) => DalContactShowroom.UpdateAsync(id, updated);
        public Task DeleteAsync(string id) => DalContactShowroom.DeleteAsync(id);
    }
}

using Dal;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalApp.Services
{
    public class ShowroomAddressService : IShowroomAddressService
    {
       
        public Task CreateAsync(EntShowroomAddress address) => DalShowroomAddress.CreateAsync(address);
        public Task<List<EntShowroomAddress>> GetAllAsync() => DalShowroomAddress.GetAllAsync();
        public Task<EntShowroomAddress?> GetByIdAsync(string id) => DalShowroomAddress.GetByIdAsync(id);
        public Task UpdateAsync(string id, EntShowroomAddress updated) => DalShowroomAddress.UpdateAsync(id, updated);
        public Task DeleteAsync(string id) => DalShowroomAddress.DeleteAsync(id);
    }
}

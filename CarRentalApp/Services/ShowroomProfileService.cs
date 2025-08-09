using Dal;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalApp.Services
{
    public class ShowroomProfileService : IShowroomProfileService
    {
       

        public Task CreateAsync(EntShowroomProfile profile) => DalShowroomProfile.CreateAsync(profile);
        public Task<List<EntShowroomProfile>> GetAllAsync() => DalShowroomProfile.GetAllAsync();
        public Task<EntShowroomProfile?> GetByIdAsync(string id) => DalShowroomProfile.GetByIdAsync(id);
        public Task UpdateAsync(string id, EntShowroomProfile updated) => DalShowroomProfile.UpdateAsync(id, updated);
        public Task DeleteAsync(string id) => DalShowroomProfile.DeleteAsync(id);
    }
}

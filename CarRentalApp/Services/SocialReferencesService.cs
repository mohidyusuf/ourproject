using Dal;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalApp.Services
{
    public class SocialReferencesService : ISocialReferencesService
    {
      

        public Task CreateAsync(EntSocialReferences refData) => DalSocialReferences.CreateAsync(refData);
        public Task<List<EntSocialReferences>> GetAllAsync() => DalSocialReferences.GetAllAsync();
        public Task<EntSocialReferences?> GetByIdAsync(string id) => DalSocialReferences.GetByIdAsync(id);
        public Task UpdateAsync(string id, EntSocialReferences updated) => DalSocialReferences.UpdateAsync(id, updated);
        public Task DeleteAsync(string id) => DalSocialReferences.DeleteAsync(id);
    }
}

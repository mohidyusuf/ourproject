using Dal;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalApp.Services
{
    public class BranchService : IBranchService
    {
       

        public Task CreateAsync(EntBranches branch) => DalBranches.CreateAsync(branch);
        public Task<List<EntBranches>> GetAllAsync() => DalBranches.GetAllAsync();
        public Task<EntBranches?> GetByIdAsync(string id) => DalBranches.GetByIdAsync(id);
        public Task UpdateAsync(string id, EntBranches updated) => DalBranches.UpdateAsync(id, updated);
        public Task DeleteAsync(string id) => DalBranches.DeleteAsync(id);
    }
}

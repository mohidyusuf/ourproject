using Entities;

namespace CarRentalApp.Services
{
    public interface IBranchService
    {
        Task CreateAsync(EntBranches branch);
        Task<List<EntBranches>> GetAllAsync();
        Task<EntBranches?> GetByIdAsync(string id);
        Task UpdateAsync(string id, EntBranches updatedBranch);
        Task DeleteAsync(string id);
    }
}

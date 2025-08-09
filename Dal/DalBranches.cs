using Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dal
{
    public static class DalBranches
    {
        private static readonly IMongoCollection<EntBranches> _branches;

         static DalBranches()
        {
            var client = new MongoClient(DbRegistration.ConnectionString);
            var database = client.GetDatabase(DbRegistration.DatabaseName);
            _branches = database.GetCollection<EntBranches>(DbRegistration.BranchCollection);
        }

        public static async Task CreateAsync(EntBranches branch)
        {
            await _branches.InsertOneAsync(branch);
        }

        public static async Task<List<EntBranches>> GetAllAsync()
        {
            return await _branches.Find(_ => true).ToListAsync();
        }

        public static async Task<EntBranches?> GetByIdAsync(string id)
        {
            return await _branches.Find(b => b.BranchEmail == id).FirstOrDefaultAsync();
        }

        public static async Task UpdateAsync(string id, EntBranches updated)
        {
            await _branches.ReplaceOneAsync(b => b.BranchEmail == id, updated);
        }

        public static async Task DeleteAsync(string id)
        {
            await _branches.DeleteOneAsync(b => b.BranchEmail == id);
        }
    }
}

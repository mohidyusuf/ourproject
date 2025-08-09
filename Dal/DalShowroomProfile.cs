using Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dal
{
    public static class DalShowroomProfile
    {
        private static readonly IMongoCollection<EntShowroomProfile> _profiles;

         static DalShowroomProfile( )
        {
            var client = new MongoClient();
            var database = client.GetDatabase(DbRegistration.DatabaseName);
            _profiles = database.GetCollection<EntShowroomProfile>(DbRegistration.ProfileCollection);
        }

        public static  async Task CreateAsync(EntShowroomProfile profile)
        {
            await _profiles.InsertOneAsync(profile);
        }

        public static async Task<List<EntShowroomProfile>> GetAllAsync()
        {
            return await _profiles.Find(_ => true).ToListAsync();
        }

        public static async Task<EntShowroomProfile?> GetByIdAsync(string logo)
        {
            return await _profiles.Find(p => p.LogoImagePath == logo).FirstOrDefaultAsync();
        }

        public static async Task UpdateAsync(string logo, EntShowroomProfile updated)
        {
            await _profiles.ReplaceOneAsync(p => p.LogoImagePath == logo, updated);
        }

        public static async Task DeleteAsync(string logo)
        {
            await _profiles.DeleteOneAsync(p => p.LogoImagePath == logo);
        }
    }
}

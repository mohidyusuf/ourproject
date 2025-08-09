using Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dal
{
    public static class DalSocialReferences
    {
        private static readonly IMongoCollection<EntSocialReferences> _socials;

         static DalSocialReferences()
        {
            var client = new MongoClient(DbRegistration.ConnectionString);
            var database = client.GetDatabase(DbRegistration.DatabaseName);
            _socials = database.GetCollection<EntSocialReferences>(DbRegistration.SocialCollection);
        }

        public static async Task CreateAsync(EntSocialReferences social)
        {
            await _socials.InsertOneAsync(social);
        }

        public static async Task<List<EntSocialReferences>> GetAllAsync()
        {
            return await _socials.Find(_ => true).ToListAsync();
        }

        public static async Task<EntSocialReferences?> GetByIdAsync(string website)
        {
            return await _socials.Find(s => s.WebsiteUrl == website).FirstOrDefaultAsync();
        }

        public static async Task UpdateAsync(string website, EntSocialReferences updated)
        {
            await _socials.ReplaceOneAsync(s => s.WebsiteUrl == website, updated);
        }

        public static async Task DeleteAsync(string website)
        {
            await _socials.DeleteOneAsync(s => s.WebsiteUrl == website);
        }
    }
}

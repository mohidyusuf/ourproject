using Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dal
{
    public static class DalAboutShowroom
    {
        private static readonly IMongoCollection<EntAboutShowroom> _aboutShowrooms;

        static DalAboutShowroom()
        {
            var client = new MongoClient(DbRegistration.ConnectionString);
            var database = client.GetDatabase(DbRegistration.DatabaseName);
            _aboutShowrooms = database.GetCollection<EntAboutShowroom>(DbRegistration.AboutCollection);
        }

        public static async Task CreateAsync(EntAboutShowroom showroom)
        {
            await _aboutShowrooms.InsertOneAsync(showroom);
        }

        public static async Task<List<EntAboutShowroom>> GetAllAsync()
        {
            return await _aboutShowrooms.Find(_ => true).ToListAsync();
        }

        public static async Task<EntAboutShowroom?> GetByIdAsync(string id)
        {
            return await _aboutShowrooms.Find(s => s.Id == id).FirstOrDefaultAsync();
        }

        public static async Task UpdateAsync(string id, EntAboutShowroom updatedShowroom)
        {
            await _aboutShowrooms.ReplaceOneAsync(s => s.Id == id, updatedShowroom);
        }

        public static async Task DeleteAsync(string id)
        {
            await _aboutShowrooms.DeleteOneAsync(s => s.Id == id);
        }
    }
}

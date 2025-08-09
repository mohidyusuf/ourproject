using Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dal
{
    public static class DalContactShowroom
    {
        private static readonly IMongoCollection<EntContactShowroom> _contacts;

         static DalContactShowroom( )
        {
            var client = new MongoClient(DbRegistration.ConnectionString);
            var database = client.GetDatabase(DbRegistration.DatabaseName);
            _contacts = database.GetCollection<EntContactShowroom>(DbRegistration.ContactCollection);
        }

        public static async Task CreateAsync(EntContactShowroom contact)
        {
            await _contacts.InsertOneAsync(contact);
        }

        public static async Task<List<EntContactShowroom>> GetAllAsync()
        {
            return await _contacts.Find(_ => true).ToListAsync();
        }

        public static async Task<EntContactShowroom?> GetByIdAsync(string phone)
        {
            return await _contacts.Find(c => c.ContactPhone == phone).FirstOrDefaultAsync();
        }

        public static async Task UpdateAsync(string phone, EntContactShowroom updated)
        {
            await _contacts.ReplaceOneAsync(c => c.ContactPhone == phone, updated);
        }

        public static async Task DeleteAsync(string phone)
        {
            await _contacts.DeleteOneAsync(c => c.ContactPhone == phone);
        }
    }
}

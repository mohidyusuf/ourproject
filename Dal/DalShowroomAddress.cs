using Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dal
{
    public class DalShowroomAddress
    {
        private static readonly IMongoCollection<EntShowroomAddress> _addresses;

         static DalShowroomAddress( )
        {
            var client = new MongoClient(DbRegistration.ConnectionString);
            var database = client.GetDatabase(DbRegistration.DatabaseName);
            _addresses = database.GetCollection<EntShowroomAddress>(DbRegistration.AddressCollection);
        }

        public static async Task CreateAsync(EntShowroomAddress address)
        {
            await _addresses.InsertOneAsync(address);
        }

        public static async Task<List<EntShowroomAddress>> GetAllAsync()
        {
            return await _addresses.Find(_ => true).ToListAsync();
        }

        public static async Task<EntShowroomAddress?> GetByIdAsync(string city)
        {
            return await _addresses.Find(a => a.City == city).FirstOrDefaultAsync();
        }

        public static async Task UpdateAsync(string city, EntShowroomAddress updated)
        {
            await _addresses.ReplaceOneAsync(a => a.City == city, updated);
        }

        public static async Task DeleteAsync(string city)
        {
            await _addresses.DeleteOneAsync(a => a.City == city);
        }
    }
}

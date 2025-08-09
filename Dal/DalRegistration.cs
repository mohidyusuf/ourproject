using Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public static class DalRegistration
    {

        private static readonly IMongoCollection<EntRegistration> _registrations;

         static DalRegistration()
        {
            var client = new MongoClient(DbRegistration.ConnectionString);
            var database = client.GetDatabase(DbRegistration.DatabaseName);
            _registrations = database.GetCollection<EntRegistration>(DbRegistration.AboutCollection);
        }

        public static async Task CreateAsync(EntRegistration registration)
        {
            await _registrations.InsertOneAsync(registration);
        }
    }
}

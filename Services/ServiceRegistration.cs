using Dal;
using Entities;
using MongoDB.Driver;

namespace CarRental.Services
{
    public class ServiceRegistration : IRegistrationService
    {
        private readonly DalRegistration _dalRegistration;

        public ServiceRegistration(DbRegistration settings)
        {
            _dalRegistration = new DalRegistration(settings);
        }

      
        public async Task CreateAsync(EntRegistration registration)
        {
           await _dalRegistration.CreateAsync(registration);
        }
    }
}

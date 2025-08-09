using Dal;
using Entities;
using MongoDB.Driver;

namespace CarRentalApp.Services
{
    public class ServiceRegistration : IRegistrationService
    {
       


        public async Task CreateAsync(EntRegistration registration)
        {
            await DalRegistration.CreateAsync(registration);
        }
    }
}

using Entities;
using Dal;

namespace CarRentalApp.Services
{
    public interface IRegistrationService
    {
        Task CreateAsync(EntRegistration registration);
    }
}

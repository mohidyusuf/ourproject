using Entities;
using Dal;

namespace CarRental.Services
{
    public interface IRegistrationService
    {
        Task CreateAsync(EntRegistration registration);
    }
}

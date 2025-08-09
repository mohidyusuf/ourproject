using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalApp.Services
{
    public interface IAboutShowroomService
    {
        Task CreateAboutShowroom(EntAboutShowroom showroom);
        Task<List<EntAboutShowroom>> GetAllShowrooms();
        Task<EntAboutShowroom> GetShowroomById(string id);
        Task UpdateShowroom(EntAboutShowroom updatedShowroom);
        Task DeleteShowroom(string id);
    }
}

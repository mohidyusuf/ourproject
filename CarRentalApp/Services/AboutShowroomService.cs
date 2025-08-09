using Dal;
using Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalApp.Services
{
    public class AboutShowroomService : IAboutShowroomService
    {
        public async Task CreateAboutShowroom(EntAboutShowroom showroom)
        {
            await DalAboutShowroom.CreateAsync(showroom);
        }

        public async Task DeleteShowroom(string id)
        {
            await DalAboutShowroom.DeleteAsync(id);
        }

        public async Task<List<EntAboutShowroom>> GetAllShowrooms()
        {
            return await DalAboutShowroom.GetAllAsync();
        }

        public async Task<EntAboutShowroom> GetShowroomById(string id)
        {
            return await DalAboutShowroom.GetByIdAsync(id) ?? new EntAboutShowroom();
        }

        public async Task UpdateShowroom(EntAboutShowroom updatedShowroom)
        {
            await DalAboutShowroom.UpdateAsync(updatedShowroom.Id, updatedShowroom);
        }
    }
}

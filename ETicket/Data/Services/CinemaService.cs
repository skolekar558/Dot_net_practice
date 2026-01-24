using ETicket.Data.Repositories;
using ETicket.Models;

namespace ETicket.Data.Services
{
    public class CinemaService : ICinemaService
    {
        private readonly ICinemaRepository _cinemaRepo;
        public CinemaService(ICinemaRepository cinemaRepo)
        {
            _cinemaRepo = cinemaRepo;
        }

        public async Task CreateCinemaAsync(Cinema cinema)
        {
            await _cinemaRepo.CreateCinemaAsync(cinema);
        }

        public async Task DeleteCinemaAsync(int id)
        {
            await _cinemaRepo.DeleteCinemaAsync(id);
        }

        public async Task<List<Cinema>> GetAllCinemasAsync()
        {
            return await _cinemaRepo.GetAllCinemasAsync();
        }

        public async Task<Cinema> GetCinemaByIdAsync(int id)
        {
            return await _cinemaRepo.GetCinemaByIdAsync(id);
        }

        public async Task UpdateCinemaAsync(Cinema cinema)
        {
            await _cinemaRepo.UpdateCinemaAsync(cinema);
        }
    }
}

using ETicket.Models;

namespace ETicket.Data.Services
{
    public interface ICinemaService
    {
        Task<Cinema> GetCinemaByIdAsync(int id);
        Task<List<Cinema>> GetAllCinemasAsync();
        Task CreateCinemaAsync(Cinema cinema);
        Task UpdateCinemaAsync(Cinema cinema);
        Task DeleteCinemaAsync(int id);
    }
}

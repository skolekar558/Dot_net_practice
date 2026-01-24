using ETicket.Models;

namespace ETicket.Data.Repositories
{
    public interface ICinemaRepository
    {
        Task<Cinema> GetCinemaByIdAsync(int id);
        Task<List<Cinema>> GetAllCinemasAsync();
        Task CreateCinemaAsync(Cinema cinema);
        Task UpdateCinemaAsync(Cinema cinema);
        Task DeleteCinemaAsync(int id);
    }
}

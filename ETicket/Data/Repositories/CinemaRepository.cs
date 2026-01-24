using ETicket.Models;
using Microsoft.EntityFrameworkCore;

namespace ETicket.Data.Repositories
{
    public class CinemaRepository:ICinemaRepository
    {

        private readonly ApplicationDbContext _context;
        public CinemaRepository(ApplicationDbContext context) {
         _context = context;
        }

        public async Task CreateCinemaAsync(Cinema cinema)
        {
            _context.Cinemas.Add(cinema);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCinemaAsync(int id)
        {
            var cinema = await _context.Cinemas.FindAsync(id);
            if (cinema != null)
            {
                _context.Cinemas.Remove(cinema);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Cinema>> GetAllCinemasAsync()
        {
            return await _context.Cinemas.ToListAsync();
        }

        public async Task<Cinema> GetCinemaByIdAsync(int id)
        {
            return await _context.Cinemas.FindAsync(id);
        }

        public async Task UpdateCinemaAsync(Cinema cinema)
        {
            _context.Entry(cinema).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

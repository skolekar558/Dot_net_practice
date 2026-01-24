using ETicket.Models;
using Microsoft.EntityFrameworkCore;

namespace ETicket.Data.Repositories
{
    public class ProducerRepository : IProducerRepository
    {
        private readonly ApplicationDbContext _context;
        public ProducerRepository(ApplicationDbContext context) {
            _context = context;
        }
        public async Task CreateProducerAsync(Producer producer)
        {
            _context.Producers.Add(producer);
            await _context.SaveChangesAsync();
        }
            public async  Task DeleteProducerAsync(int id)
        {
            var producer = await _context.Producers.FindAsync(id);
            if (producer != null)
            {
                _context.Producers.Remove(producer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Producer> GetProducerByIdAsync(int id)
        {
            return await _context.Producers.FindAsync(id);
        }

        public async Task<List<Producer>> GetAllProducerAsync()
        {
            return await _context.Producers.ToListAsync();
        }

        public async Task UpdateProducerAsync(Producer producer)
        {
            _context.Entry(producer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

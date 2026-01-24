using ETicket.Models;
using Microsoft.EntityFrameworkCore;

namespace ETicket.Data.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly ApplicationDbContext _context;
        public ActorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateActorAsync(Actor actor)
        {
            _context.Actors.Add(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteActorAsync(int id)
        {
            var actor = await _context.Actors.FindAsync(id);
            if (actor != null)
            {
                _context.Actors.Remove(actor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Actor>GetActorByIdAsync(int id)
        {
            return await _context.Actors.FindAsync(id);
        }

        public async Task<List<Actor>> GetAllActorsAsync()
        {
            return await _context.Actors.ToListAsync();
        }

        public async Task UpdateActorAsync(Actor actor)
        {
            _context.Entry(actor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

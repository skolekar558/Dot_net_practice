using ETicket.Models;

namespace ETicket.Data.Repositories
{
    public interface IActorRepository
    {
        Task<Actor> GetActorByIdAsync(int id);
        Task<List<Actor>> GetAllActorsAsync();
        Task CreateActorAsync(Actor actor);
        Task UpdateActorAsync(Actor actor);
        Task DeleteActorAsync(int id);
    }
}
 
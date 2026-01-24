

using ETicket.Models;

namespace ETicket.Data.Services
{
    public interface IActorsService
    {
        Task<Actor> GetActorByIdAsync(int id);
        Task<List<Actor>> GetAllActorsAsync();
        Task CreateActorAsync(Actor actor);
        Task UpdateActorAsync(Actor actor);
        Task DeleteActorAsync(int id);
    }
}



using ETicket.Data.Repositories;
using ETicket.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ETicket.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly IActorRepository _actorRepo;

        public ActorsService(IActorRepository actorRepo)
        {
            _actorRepo = actorRepo;
        }
        public Task<Actor> GetActorByIdAsync(int id)
        {
            return _actorRepo.GetActorByIdAsync(id);
        }

        public Task<List<Actor>> GetAllActorsAsync()
        {
            return _actorRepo.GetAllActorsAsync();
        }

        public Task CreateActorAsync(Actor actor)
        {
            return _actorRepo.CreateActorAsync(actor);
        }

        public Task UpdateActorAsync(Actor actor)
        {
            return _actorRepo.UpdateActorAsync(actor);
        }

        public Task DeleteActorAsync(int id)
        {
            return _actorRepo.DeleteActorAsync(id);
        }
    }

}

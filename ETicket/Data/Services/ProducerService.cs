using ETicket.Data.Repositories;
using ETicket.Models;

namespace ETicket.Data.Services
{
    public class ProducerService : IProducerService
    {
        private readonly IProducerRepository _producerRepo;
        public ProducerService(IProducerRepository producerRepo)
        {
            _producerRepo = producerRepo;
        }
        public async Task CreateProducerAsync(Producer producer)
        {
            await _producerRepo.CreateProducerAsync(producer);
        }

        public async Task DeleteProducerAsync(int id)
        {
            await _producerRepo.DeleteProducerAsync(id);
        }

        public async Task<List<Producer>> GetAllProducersAsync()
        {
            return await _producerRepo.GetAllProducerAsync();
        }

        public async  Task<Producer> GetProducerByIdAsync(int id)
        {
            return await _producerRepo.GetProducerByIdAsync(id);
        }

        public async Task UpdateProducerAsync(Producer producer)
        {
            await _producerRepo.UpdateProducerAsync(producer);
        }
    }
}

using ETicket.Models;

namespace ETicket.Data.Repositories
{
    public interface IProducerRepository
    {
        Task<Producer> GetProducerByIdAsync(int id);
        Task<List<Producer>> GetAllProducerAsync();
        Task CreateProducerAsync(Producer producer);
        Task UpdateProducerAsync(Producer producer);
        Task DeleteProducerAsync(int id); 
    }
}

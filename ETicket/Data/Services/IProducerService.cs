using ETicket.Models;

namespace ETicket.Data.Services
{
    public interface IProducerService
    {

        Task<Producer> GetProducerByIdAsync(int id);
        Task<List<Producer>> GetAllProducersAsync();
        Task CreateProducerAsync(Producer producer);
        Task UpdateProducerAsync(Producer producer);
        Task DeleteProducerAsync(int id);
    }
}

using ETicket.Data.Base;
using ETicket.Data.ViewModels;
using ETicket.Models;
using System.Linq.Expressions;

namespace ETicket.Data.Services
{
    public interface IMovieService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);

    }
}

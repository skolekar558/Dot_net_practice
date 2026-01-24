using ETicket.Data.ViewModels;
using ETicket.Models;
using System.Linq.Expressions;

namespace ETicket.Data.Repositories
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllMoviesAsync();
        Task<List<Movie>> GetAllMoviesAsync(params Expression<Func<Movie, object>>[] includeProperties);
        Task<Movie> GetMovieByIdAsync(int id);
        Task AddNewMovieAsync(NewMovieVM newMovie);
        Task UpdateMovieAsync(NewMovieVM updatedMovie);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

    }
}

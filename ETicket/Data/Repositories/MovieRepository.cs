using ETicket.Data.ViewModels;
using ETicket.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ETicket.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;
        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<List<Movie>> GetAllMoviesAsync(params Expression<Func<Movie, object>>[] includeProperties)
        {
            IQueryable<Movie> query = _context.Movies;

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.ToListAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task AddNewMovieAsync(NewMovieVM newMovie)
        {
            var movie = new Movie
            {
                Name = newMovie.Name,
                Description = newMovie.Description,
                Price = newMovie.Price,
                ImageURL = newMovie.ImageURL,
                StartDate = newMovie.StartDate,
                EndDate = newMovie.EndDate,
                MovieCategory = newMovie.MovieCategory,
                CinemaId = newMovie.CinemaId,
                ProducerId = newMovie.ProducerId
            };

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMovieAsync(NewMovieVM updatedMovie)
        {
            var movie = await _context.Movies.FindAsync(updatedMovie.Id);

            if (movie != null)
            {
                movie.Name = updatedMovie.Name;
                movie.Description = updatedMovie.Description;
                movie.Price = updatedMovie.Price;
                movie.ImageURL = updatedMovie.ImageURL;
                movie.StartDate = updatedMovie.StartDate;
                movie.EndDate = updatedMovie.EndDate;
                movie.MovieCategory = updatedMovie.MovieCategory;
                movie.CinemaId = updatedMovie.CinemaId;
                movie.ProducerId = updatedMovie.ProducerId;

                _context.Movies.Update(movie);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues()
        {
            var dropdowns = new NewMovieDropdownsVM
            {
                Cinemas = await _context.Cinemas.OrderBy(c => c.Name).ToListAsync(),
                Producers = await _context.Producers.OrderBy(p => p.FullName).ToListAsync(),
                Actors = await _context.Actors.OrderBy(a => a.FullName).ToListAsync()
            };

            return dropdowns;
        
    }
    }

    }
    


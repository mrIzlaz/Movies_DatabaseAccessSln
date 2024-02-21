using CodeAlong_240215.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CodeAlong_240215.Data
{
    public class DataAccess
    {
        private readonly MovieContext _movieContext;

        public DataAccess(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public Task<List<Movie>> GetAllMovies()
        {
            var movies = _movieContext.Movies.ToListAsync();
            return movies;
        }

        public async Task AddMovie(Movie movie)
        {
            await _movieContext.AddAsync(movie);
            await _movieContext.SaveChangesAsync();
        }

        public async Task UpdateMovie(Movie movie)
        {
            _movieContext.Movies.Update(movie);
            await _movieContext.SaveChangesAsync();
        }
        public async Task<Movie?> GetMovieById(int id)
        {
            return await _movieContext.Movies.FindAsync(id);
        }
    }
}

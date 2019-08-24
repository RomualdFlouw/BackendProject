using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CinemaDemoModels.Models;

namespace CinemaDemoModels.Repositories
{
    public interface IMovieRepository
    {
        Task DeleteMovieAsync(Movie movie);
        Task<Movie> GetMovieAsync(Guid movieId);
        Task<IEnumerable<Movie>> GetMoviesAsync();
        Task<Movie> SaveMovieAsync(Movie movie);
        Task<Movie> UpdateMovieAsync(Movie movie);
    }
}
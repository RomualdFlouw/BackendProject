using CinemaDemoModels.Data;
using CinemaDemoModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDemoModels.Repositories
{
    public class MovieRepository : IMovieRepository
    {

        //fields
        private readonly CinemaDbContext _context;

        //constructor
        public MovieRepository(CinemaDbContext context)
        {
            this._context = context;
        }

        //methods
        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie> GetMovieAsync(Guid movieId)
        {
            return await _context.Movies.SingleOrDefaultAsync(m => m.Id == movieId);

            // 3 andere mogelijkheden
            //return await _context.Movies.FindAsync(movieId);
            //return await _context.Movies.FirstOrDefaultAsync(m => m.Id == movieId);
            //return await _context.Movies.LastOrDefaultAsync(m => m.Id == movieId);
        }

        public async Task<Movie> SaveMovieAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> UpdateMovieAsync(Movie movie)
        {
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
            return movie;
        }
        public async Task DeleteMovieAsync(Movie movie)
        {
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

        }
    }
}

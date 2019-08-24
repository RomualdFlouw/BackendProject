using CinemaDemoModels.Data;
using CinemaDemoModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDemoModels.Repositories
{
    public class MovieRoomRepository : IMovieRoomRepository
    {
        //fields
        private readonly CinemaDbContext _context;

        //constructor
        public MovieRoomRepository(CinemaDbContext context)
        {
            this._context = context;
        }

        //methods
        public async Task<IEnumerable<MovieRoom>> GetMovieRoomsAsync()
        {
            return await _context.MovieRooms.ToListAsync();
        }

        public async Task<MovieRoom> GetMovieRoomAsync(Guid movieRoomId)
        {
            return await _context.MovieRooms.SingleOrDefaultAsync(m => m.Id == movieRoomId);

            // 3 andere mogelijkheden
            //return await _context.Movies.FindAsync(movieId);
            //return await _context.Movies.FirstOrDefaultAsync(m => m.Id == movieId);
            //return await _context.Movies.LastOrDefaultAsync(m => m.Id == movieId);
        }

        public async Task<MovieRoom> SaveMovieRoomAsync(MovieRoom movieRoom)
        {
            await _context.MovieRooms.AddAsync(movieRoom);
            await _context.SaveChangesAsync();
            return movieRoom;
        }

        public async Task<MovieRoom> UpdateMovieRoomAsync(MovieRoom movieRoom)
        {
            _context.MovieRooms.Update(movieRoom);
            await _context.SaveChangesAsync();
            return movieRoom;
        }
        public async Task DeleteMovieRoomAsync(MovieRoom movieRoom)
        {
            _context.MovieRooms.Remove(movieRoom);
            await _context.SaveChangesAsync();

        }
    }
}

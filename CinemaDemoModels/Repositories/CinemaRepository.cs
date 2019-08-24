using CinemaDemoModels.Data;
using CinemaDemoModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDemoModels.Repositories
{
    public class CinemaRepository : ICinemaRepository
    {
        private readonly CinemaDbContext _context;

        public CinemaRepository(CinemaDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }

        public async Task<IEnumerable<Cinema>> GetCinemasAsync()
        {
            return await _context.Cinemas.ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetTicketsAsync()
        {
            return await _context.Tickets.ToListAsync();
        }

        public async Task<Cinema> GetCinemaWithMoviesAsync(Guid id)
        {
            return await _context.Cinemas
                .Include(c => c.Rooms)
                .ThenInclude(r => r.MovieRooms)
                .ThenInclude(mr => mr.Movie)
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Room> GetRoomsAsync(Guid id)
        {
            return await _context.Rooms
                .Include(c => c.Seats)
                .ThenInclude(r => r.Tickets)
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task PostTicketAsync(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();
        }

        public async Task<AspNetUser> GetUserByName(string userName)
        {
            return await _context.AspNetUsers.Where(u => u.UserName == userName)
                .Include(r => r.Tickets)
                .SingleAsync();
        }

        public async Task<Seat> GetSeatById (Guid id)
        {
            return await _context.Seats.Where(r => r.Id == id)
                .SingleOrDefaultAsync(c => c.Id == id);
        }
    }
}

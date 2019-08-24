using CinemaDemoModels.Data;
using CinemaDemoModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDemoModels.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        //fields
        private readonly CinemaDbContext _context;

        //constructor
        public TicketRepository(CinemaDbContext context)
        {
            this._context = context;
        }

        //methods
        public async Task<IEnumerable<Ticket>> GetTicketsAsync()
        {
            return await _context.Tickets.ToListAsync();
        }

        public async Task<Ticket> GetTicketAsync(Guid TicketId)
        {
            return await _context.Tickets.SingleOrDefaultAsync(m => m.Id == TicketId);
        }

        public async Task<Ticket> SaveTicketAsync(Ticket ticket)
        {
            await _context.Tickets.AddAsync(ticket);
            await _context.SaveChangesAsync();
            return ticket;
        }

        public async Task<Ticket> UpdateTicketAsync(Ticket ticket)
        {
            _context.Tickets.Update(ticket);
            await _context.SaveChangesAsync();
            return ticket;
        }
        public async Task DeleteTicketAsync(Ticket ticket)
        {
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();

        }
    }
}

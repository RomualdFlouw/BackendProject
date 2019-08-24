using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CinemaDemoModels.Models;

namespace CinemaDemoModels.Repositories
{
    public interface ITicketRepository
    {
        Task DeleteTicketAsync(Ticket ticket);
        Task<Ticket> GetTicketAsync(Guid TicketId);
        Task<IEnumerable<Ticket>> GetTicketsAsync();
        Task<Ticket> SaveTicketAsync(Ticket ticket);
        Task<Ticket> UpdateTicketAsync(Ticket ticket);
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CinemaDemoModels.Models;

namespace CinemaDemoModels.Repositories
{
    public interface ICinemaRepository
    {
        Task<IEnumerable<Cinema>> GetCinemasAsync();
        Task<Cinema> GetCinemaWithMoviesAsync(Guid id);
        Task<Room> GetRoomsAsync(Guid id);
        Task<IEnumerable<Ticket>> GetTicketsAsync();
        Task<AspNetUser> GetUserByName(string userName);
        Task PostTicketAsync(Ticket ticket);
        Task<Seat> GetSeatById(Guid id);
    }
}
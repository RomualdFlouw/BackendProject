using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CinemaDemoModels.Models;

namespace CinemaDemoModels.Repositories
{
    public interface IMovieRoomRepository
    {
        Task DeleteMovieRoomAsync(MovieRoom movieRoom);
        Task<MovieRoom> GetMovieRoomAsync(Guid movieRoomId);
        Task<IEnumerable<MovieRoom>> GetMovieRoomsAsync();
        Task<MovieRoom> SaveMovieRoomAsync(MovieRoom movieRoom);
        Task<MovieRoom> UpdateMovieRoomAsync(MovieRoom movieRoom);
    }
}
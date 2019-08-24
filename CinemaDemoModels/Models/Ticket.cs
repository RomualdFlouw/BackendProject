using System;

namespace CinemaDemoModels.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }

        // one - to many
        public Guid SeatId { get; set; }
        public Guid MovieRoomId { get; set; }
        public string AspNetUserId { get; set; }
        public Guid MovieRoomMovieId { get; set; }
        public Guid MovieRoomRoomId { get; set; }
        public DateTime MovieRoomPlayTime { get; set; }

        public MovieRoom MovieRoom { get; set; }
        public Seat  Seat { get; set; }
        public AspNetUser AspNetUser { get; set; }
    }
}

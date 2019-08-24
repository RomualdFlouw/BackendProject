using System;
using System.Collections.Generic;

namespace CinemaDemoModels.Models
{
    public class MovieRoom
    {
        public Guid Id { get; set; }
        public DateTime PlayTime { get; set; }

        public Guid MovieId { get; set; }
        public Guid RoomId { get; set; }

        public Room Room { get; set; }
        public Movie Movie { get; set; }

        public IEnumerable<Ticket> Tickets { get; set; }
    }
}

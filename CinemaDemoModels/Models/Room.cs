using System;
using System.Collections.Generic;

namespace CinemaDemoModels.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public int Nr { get; set; }

        // one - to many relation
        public Guid CinemaId { get; set; }

        // lookup
        public Cinema Cinema { get; set; }


        // lookup
        public IEnumerable<Seat> Seats { get; set; }
        public IEnumerable<MovieRoom> MovieRooms { get; set; }

    }
}

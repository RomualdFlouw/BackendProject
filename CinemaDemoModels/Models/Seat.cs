using System;
using System.Collections.Generic;

namespace CinemaDemoModels.Models
{
    public class Seat
    {
        public Guid Id { get; set; }
        
        public int Nr { get; set; }
        public int RowNr { get; set; }

        // one to many
        public Guid RoomId { get; set; }
        public Room Room { get; set; }

        public IEnumerable<Ticket> Tickets { get; set; }
    }
}

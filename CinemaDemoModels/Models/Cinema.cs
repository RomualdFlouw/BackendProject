using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaDemoModels.Models
{
    public class Cinema
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        // lookup
        public IEnumerable<Room> Rooms { get; set; }
    }
}

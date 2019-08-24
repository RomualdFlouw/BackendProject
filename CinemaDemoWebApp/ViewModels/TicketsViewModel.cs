using CinemaDemoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaDemoWebApp.ViewModels
{
    public class TicketsViewModel
    {
        public Room room { get; set; }
        public Guid MovieRoomId { get; set; }
        public DateTime Playtime { get; set; }
        public Guid MovieId { get; set; }
    }
}

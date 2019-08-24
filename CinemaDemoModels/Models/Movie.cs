using System;
using System.Collections.Generic;

namespace CinemaDemoModels.Models
{
    public class Movie
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public TimeSpan Duration { get; set; }

        public IEnumerable<MovieRoom> MovieRooms { get; set; }
    }
}

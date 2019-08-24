using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaDemoModels.Models
{
    public class AspNetUser
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public IEnumerable<Ticket> Tickets { get; set; }
    }
}

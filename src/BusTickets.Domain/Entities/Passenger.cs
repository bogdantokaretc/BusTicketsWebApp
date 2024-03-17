using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTickets.Domain.Entities
{
    public class Passenger: IdentityUser
    {
        public List<Ticket> Tickets { get; set; }

    }
}

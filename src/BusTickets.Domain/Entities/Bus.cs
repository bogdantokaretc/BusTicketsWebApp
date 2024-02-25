using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTickets.Domain.Entities
{
    public class Bus
    {
        public int Id { get; set; }
        public string BusNumber { get; set; }
        public string BusModel { get; set; }
        public List<Seat> Seats { get; set; }
        public string Carrier { get; set;}
    }
}
    

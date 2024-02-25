using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTickets.Domain.Entities
{
    public class Seat
    {
        public int Id { get; set; }
        public string SeatNumber { get; set; }
        public string SeatType { get; set; }
        public bool IsBooked { get; set; }
        public int BusId { get; set; }
        public Bus Bus { get; set; }
    }
}

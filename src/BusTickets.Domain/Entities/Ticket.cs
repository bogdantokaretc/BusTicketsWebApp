using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTickets.Domain.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public int BusId { get; set; }
        public Bus Bus { get; set; }
        public int SeatId { get; set; }
        public Seat Seat { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }
        public DateTime PurchaseTime { get; set; }
    }
}

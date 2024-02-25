using BusTickets.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTickets.Infrastructure.Data.Migrations
{
    public class BusTicketDbContext: DbContext
    {
        public BusTicketDbContext(DbContextOptions<BusTicketDbContext> options): base(options){}

        public DbSet<Bus> Buses { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Route> Routes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BusTicketDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }

}

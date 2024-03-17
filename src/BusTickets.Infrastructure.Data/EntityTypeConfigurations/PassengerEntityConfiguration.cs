using BusTickets.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BusTickets.Infrastructure.Data.EntityTypeConfigurations
{
    internal class PassengerEntityConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.HasMany(p => p.Tickets)
              .WithOne(t => t.Passenger)
              .HasForeignKey(t => t.PassengerId)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

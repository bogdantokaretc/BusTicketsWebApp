using BusTickets.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTickets.Infrastructure.Data.EntityTypeConfigurations
{
    internal class RouteEntityConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.DepartureCity).IsRequired();
            builder.Property(r => r.ArrivalCity).IsRequired();
            builder.Property(r => r.DepartureTime).IsRequired();
            builder.Property(r => r.ArrivalTime).IsRequired();
            builder.Property(r => r.Price).IsRequired()
                   .HasColumnType("decimal(18, 2)");

            builder.HasMany(t => t.Tickets)
                   .WithOne(r => r.Route)
                   .HasForeignKey(t => t.RouteId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

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
    internal class SeatEntityConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.SeatNumber).IsRequired();
            builder.Property(s => s.IsBooked).IsRequired();
            builder.Property(s=> s.SeatType).IsRequired();
        }
    }
}

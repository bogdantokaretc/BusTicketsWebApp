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
    internal class BusEnitityConfiguration : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.BusNumber).IsRequired();
            builder.Property(b => b.BusModel).IsRequired();
            builder.Property(b=>b.Carrier).IsRequired();

            builder.HasMany(b => b.Seats)
                   .WithOne(s => s.Bus)
                   .HasForeignKey(s => s.BusId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

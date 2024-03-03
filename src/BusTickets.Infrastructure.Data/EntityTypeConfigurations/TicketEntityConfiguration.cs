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
    internal class TicketEntityConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => t.Id);
        
            builder.Property(t => t.PurchaseTime)
                   .HasDefaultValueSql("getdate()")
                   .ValueGeneratedOnAdd();
            
            builder.HasOne(t => t.Passenger)
                   .WithMany(p => p.Tickets)
                   .HasForeignKey(t => t.PassengerId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Bus)
                   .WithMany()
                   .HasForeignKey(t => t.BusId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Seat)
                   .WithMany()
                   .HasForeignKey(t => t.SeatId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

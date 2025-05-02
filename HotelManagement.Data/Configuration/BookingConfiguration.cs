using HotelManagement.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data.Configuration
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(b => b.BookingId);

            builder.Property(b => b.BookingDate);

            builder.Property(b => b.CheckInDate).HasColumnType("Date");

            builder.Property(b => b.CheckOutDate).HasColumnType("Date");

            builder.Property(b => b.NumberCustomer);

            builder.HasOne(b => b.Customer)
                .WithMany(r => r.Booking)
                .HasForeignKey(b => b.CustomerID);

            builder.HasOne(b => b.Room)
                .WithMany(r => r.Booking)
                .HasForeignKey(b => b.RoomID);

            
        }
    }
}

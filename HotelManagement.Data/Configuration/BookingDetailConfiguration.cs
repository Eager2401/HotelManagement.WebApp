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
    public class BookingDetailConfiguration : IEntityTypeConfiguration<BookingDetail>
    {
        public void Configure(EntityTypeBuilder<BookingDetail> builder)
        {
            builder.HasKey(bd => bd.BookingDetailID);

            builder.Property(bd => bd.Price);

            builder.Property(bd => bd.Status);

            builder.Property(bd => bd.Description);

            builder.HasOne(bd => bd.Booking)
                .WithMany(b => b.BookingDetail)
                .HasForeignKey(bd => bd.BookingID);
        }
    }
}

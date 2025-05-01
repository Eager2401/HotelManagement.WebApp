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
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(r => r.RoomID);

            builder.Property(r => r.RoomName);

            builder.Property(r => r.Status);

            builder.HasOne(r => r.RoomType)
                .WithMany(rt => rt.Room)
                .HasForeignKey(r => r.RoomTypeID);

            builder.HasOne(r => r.Staff)
                .WithMany(s => s.Room)
                .HasForeignKey(r => r.StaffID);
        }

    }
}

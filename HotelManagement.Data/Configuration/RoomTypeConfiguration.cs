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
    public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.HasKey(rt => rt.RoomTypeID);

            builder.Property(rt => rt.RoomTypeName);

            builder.Property(rt => rt.PricePerNight);

            builder.Property(rt => rt.Capacity);

            builder.Property(rt => rt.Description);
        }
    }
}

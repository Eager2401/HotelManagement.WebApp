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
    public class IventoryItemConfiguration : IEntityTypeConfiguration<IventoryItem>
    {
        public void Configure(EntityTypeBuilder<IventoryItem> builder)
        {
            builder.HasKey(i => i.ItemID);

            builder.Property(i => i.ItemName);

            builder.Property(i => i.Quantity);

            builder.Property(i => i.UnitPrice);

            builder.Property(i => i.Supplier);

            builder.HasOne(i => i.Staff)
                .WithMany(s => s.IventoryItem)
                .HasForeignKey(i => i.StaffID);
        }
    }
}

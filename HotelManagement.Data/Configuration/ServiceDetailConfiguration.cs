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
    public class ServiceDetailConfiguration : IEntityTypeConfiguration<ServiceDetail>
    {
        public void Configure(EntityTypeBuilder<ServiceDetail> builder)
        {
            builder.HasKey(sd => sd.ServiceDetailID);

            builder.Property(sd => sd.UseNumber);

            builder.Property(sd => sd.TotalPrice);

            builder.Property(sd => sd.Memo);

            builder.HasOne(sd => sd.Service)
                .WithMany(s => s.ServiceDetail)
                .HasForeignKey(s => s.ServiceID);
        }
    }
}

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
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(sr => sr.ServiceID);

            builder.Property(sr => sr.ServiceName);

            builder.Property(sr => sr.Description);

            builder.Property(sr => sr.Price);

            builder.HasOne(sr => sr.Staff)
                .WithMany(st => st.Service)
                .HasForeignKey(sr => sr.StaffID);
        }
    }
}

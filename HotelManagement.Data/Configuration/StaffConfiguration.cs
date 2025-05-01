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
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(s => s.StaffId);
            
            builder.Property(s => s.FullName);

            builder.Property(s => s.PhoneNumber);

            builder.Property(s => s.Email);

            builder.Property(s => s.Address);

            builder.Property(s => s.HireDate);

            builder.Property(s => s.Salary);

            builder.HasOne(s => s.StaffType)
                .WithMany(st => st.Staff)
                .HasForeignKey(s => s.StaffTypeID);


        }
    }
}

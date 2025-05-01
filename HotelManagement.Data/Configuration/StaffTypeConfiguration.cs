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
    public class StaffTypeConfiguration : IEntityTypeConfiguration<StaffType>
    {
        public void Configure(EntityTypeBuilder<StaffType> builder)
        {
            builder.HasKey(st => st.StaffTypeID);

            builder.Property(st => st.StaffTypeName);

            builder.Property(st => st.StaffDescription);
        }
    }
}

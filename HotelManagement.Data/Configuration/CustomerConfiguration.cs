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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.CustomerId);

            builder.Property(c => c.CustomerName);
            
            builder.Property(c => c.email);

            builder.Property(c => c.Address);

            builder.Property(c => c.IdentifyCode);

            builder.Property(c => c.Age);

            builder.Property(c => c.PhoneNumber);

            builder.Property(c => c.Nationality);

            builder.HasOne(c => c.Account)
                .WithOne(a => a.Customer)
                .HasForeignKey<Customer>(c => c.AccountID);

            builder.HasOne(c => c.CustomerType)
                .WithMany(ct => ct.Customer)
                .HasForeignKey(c => c.CustomerTypeID);

        }
    }
}

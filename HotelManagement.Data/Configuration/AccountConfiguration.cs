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
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(a=>a.AccountID);

            builder.Property(a => a.AccountName).IsRequired();

            builder.Property(a => a.AccountPass).IsRequired();

            builder.Property(a => a.CreatedAt);

            builder.Property(a => a.Email).IsRequired();

            

            
        }
    }
}

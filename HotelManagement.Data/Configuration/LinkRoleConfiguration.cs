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
    public class LinkRoleConfiguration : IEntityTypeConfiguration<LinkRole>
    {
        public void Configure(EntityTypeBuilder<LinkRole> builder)
        {
            builder.HasKey(lk => lk.RoleID);

            builder.HasAlternateKey(lk => lk.AccountID);
        }
    }
}

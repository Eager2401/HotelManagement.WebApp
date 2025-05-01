using HotelManagement.Data.Configuration;
using HotelManagement.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data.EntityFramework
{
    public class HTMDbContext : DbContext
    {
        public HTMDbContext(DbContextOptions<HTMDbContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<LinkRole> LinkRoles { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerType> CustomerTypes { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomType> RoomTypes { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<BookingDetail> BookingDetails { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<StaffType> StaffTypes { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<ServiceDetail> ServiceDetails { get; set; }

        public DbSet<IventoryItem> Iventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());

            modelBuilder.ApplyConfiguration(new BookingConfiguration());

            modelBuilder.ApplyConfiguration(new BookingDetailConfiguration());

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());

            modelBuilder.ApplyConfiguration(new CustomerTypeConfiguration());

            modelBuilder.ApplyConfiguration(new IventoryItemConfiguration());

            modelBuilder.ApplyConfiguration(new LinkRoleConfiguration());

            modelBuilder.ApplyConfiguration(new PaymentConfiguration());

            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            modelBuilder.ApplyConfiguration(new RoomConfiguration());

            modelBuilder.ApplyConfiguration(new RoomTypeConfiguration());

            modelBuilder.ApplyConfiguration(new ServiceConfiguration());

            modelBuilder.ApplyConfiguration(new ServiceDetailConfiguration());

            modelBuilder.ApplyConfiguration(new StaffConfiguration());

            modelBuilder.ApplyConfiguration(new StaffTypeConfiguration());


        }
    }
}


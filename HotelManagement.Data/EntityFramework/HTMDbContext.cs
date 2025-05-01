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


            /*// Customer - CustomerType (N - 1)
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.CustomerType)
                .WithMany(ct => ct.Customer)
                .HasForeignKey(c => c.CustomerTypeID);

            // Customer - Account (1 - 1)
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Account)
                .WithOne(a => a.Customer)
                .HasForeignKey<Customer>(c => c.AccountID);

            // Staff - StaffType (N - 1)
            modelBuilder.Entity<Staff>()
                .HasOne(s => s.StaffType)
                .WithMany(st => st.Staff)
                .HasForeignKey(s => s.StaffTypeID);

            // Room - RoomType (N - 1)
            modelBuilder.Entity<Room>()
                .HasOne(r => r.RoomType)
                .WithMany(rt => rt.Room)
                .HasForeignKey(r => r.RoomTypeID);

            // Room - Staff (N - 1)
            modelBuilder.Entity<Room>()
                .HasOne(r => r.Staff)
                .WithMany(s => s.Room)
                .HasForeignKey(r => r.StaffID);

            // Booking - Customer (N - 1)
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Customer)
                .WithMany(c => c.Booking)
                .HasForeignKey(b => b.CustomerID);

            // Booking - Room (N - 1)
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Room)
                .WithMany(r => r.Booking)
                .HasForeignKey(b => b.RoomID);

            // Booking - Payment (1 - 1)
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Booking)
                .WithOne(b => b.Payment)
                .HasForeignKey<Payment>(p => p.BookingID);

            // InventoryItem - Staff (N - 1)
            modelBuilder.Entity<IventoryItem>()
                .HasOne(i => i.Staff)
                .WithMany(s => s.Iventory)
                .HasForeignKey(i => i.StaffID);

            // Service - Staff (N - 1)
            modelBuilder.Entity<Service>()
                .HasOne(s => s.Staff)
                .WithMany(st => st.Service)
                .HasForeignKey(s => s.StaffID);

            // Service - Customer (N - 1)
            modelBuilder.Entity<Service>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.Service)
                .HasForeignKey(s => s.CustomerID);*/
        }
    }
}


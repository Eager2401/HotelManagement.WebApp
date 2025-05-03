using HotelManagement.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(
                new Account() { AccountID = 1, AccountName = "Admin1", AccountPass = "12345678", 
                    CreatedAt = new DateOnly(2025, 05, 03), Email = "hieugia58555@gmail.com" },
                new Account() {AccountID =2, AccountName = "Admin2", AccountPass = "000000hieu",
                    CreatedAt = new DateOnly(2025, 05, 03), Email = "hieugia5855@gmail.com"},
                new Account() { AccountID = 3, AccountName = "Admin3", AccountPass = "000000hi",
                    CreatedAt = new DateOnly(2025, 05, 03), Email = "bosseager0175@gmail.com"},
                new Account
                {
                    AccountID = 4,
                    AccountName = "Admin1",
                    AccountPass = "000000hi",
                    CreatedAt = new DateOnly(2025, 05, 03),
                    Email = "nva@example.com",
                },
                new Account
                {
                    AccountID = 5,
                    AccountName = "Admin2",
                    AccountPass = "000000hi",
                    CreatedAt = new DateOnly(2025, 05, 03),
                    Email = "ltb@example.com",
                }
             );

            modelBuilder.Entity<Customer>().HasData(
                 new Customer
                     {
                         CustomerId = 1,
                         CustomerName = "Nguyen Van A",
                         PhoneNumber = "0912345678",
                         IdentifyCode = "123456789",
                         Address = "Hà Nội",
                         email = "nva@example.com",
                         Age = 30,
                         Nationality = "Việt Nam",
                         AccountID = 4,
                         CustomerTypeID = 1
                     },

                 new Customer
                    {
                        CustomerId = 2,
                        CustomerName = "Le Thi B",
                        PhoneNumber = "0987654321",
                        IdentifyCode = "987654321",
                        Address = "Đà Nẵng",
                        email = "ltb@example.com",
                        Age = 25,
                        Nationality = "Việt Nam",
                        AccountID = 5,
                        CustomerTypeID = 2
                    }
            );

            modelBuilder.Entity<CustomerType>().HasData(
                new CustomerType { CustomerTypeID = 1, CustomerTypesName = "Regular", Description  = "Khách hàng thông thường." },
                new CustomerType { CustomerTypeID = 2, CustomerTypesName = "VIP", Description = "Khách hàng VIP."},
                new CustomerType { CustomerTypeID = 3, CustomerTypesName = "Corporate", Description = "Khách hàng là tổ chức hoặc doanh nghiệp." } 
            );

            modelBuilder.Entity<IventoryItem>().HasData(
                new IventoryItem
                {
                    ItemID = 1,
                    ItemName = "Khăn tắm",
                    Quantity = 100,
                    UnitPrice = 20000m,
                    Supplier = "Công ty Dệt May ABC"
                },
                new IventoryItem
                {
                    ItemID = 2,
                    ItemName = "Xà phòng",
                    Quantity = 500,
                    UnitPrice = 5000m,
                    Supplier = "Hóa mỹ phẩm XYZ"
                },
                new IventoryItem
                {
                    ItemID = 3,
                    ItemName = "Nước suối",
                    Quantity = 200,
                    UnitPrice = 8000m,
                    Supplier = "Nước khoáng LaVie"
                },
                new IventoryItem
                {
                    ItemID = 4,
                    ItemName = "Kem đánh răng",
                    Quantity = 300,
                    UnitPrice = 6000m,
                    Supplier = "Colgate"
                },
                new IventoryItem
                {
                    ItemID = 5,
                    ItemName = "Bàn chải đánh răng",
                    Quantity = 300,
                    UnitPrice = 7000m,
                    Supplier = "Unilever"
                },
                new IventoryItem
                {
                    ItemID = 6,
                    ItemName = "Dép đi trong phòng",
                    Quantity = 150,
                    UnitPrice = 15000m,
                    Supplier = "Công ty Giày Dép 24h"
                },
                new IventoryItem
                {
                    ItemID = 7,
                    ItemName = "Giấy vệ sinh",
                    Quantity = 400,
                    UnitPrice = 10000m,
                    Supplier = "Tissue Việt"
                },
                new IventoryItem
                {
                    ItemID = 8,
                    ItemName = "Chăn dự phòng",
                    Quantity = 50,
                    UnitPrice = 120000m,
                    Supplier = "Nệm Bình Dương"
                }
                );

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    RoleID = 1,
                    Name = "Admin",
                    Description = "Quản trị viên hệ thống, có toàn quyền quản lý người dùng, phân quyền và cấu hình hệ thống."
                },
                new Role
                {
                    RoleID = 2,
                    Name = "Receptionist",
                    Description = "Lễ tân khách sạn, quản lý thông tin đặt phòng, check-in, check-out và hỗ trợ khách hàng."
                },
                new Role
                {
                    RoleID = 3,
                    Name = "Housekeeping",
                    Description = "Nhân viên buồng phòng, chịu trách nhiệm vệ sinh và chuẩn bị phòng cho khách."
                },
                new Role
                {
                    RoleID = 4,
                    Name = "Accountant",
                    Description = "Kế toán, quản lý hóa đơn, chi phí và các báo cáo tài chính."
                },
                new Role
                {
                    RoleID = 5,
                    Name = "Manager",
                    Description = "Quản lý chung, giám sát hoạt động của các bộ phận và theo dõi báo cáo hiệu suất."
                }
            );
        }
    }
}

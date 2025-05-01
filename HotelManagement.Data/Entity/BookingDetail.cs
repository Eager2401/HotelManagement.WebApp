using HotelManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data.Entity
{
    public class BookingDetail
    {
        public int BookingDetailID { get; set; }
        public decimal Price { get; set; }

        public BookingDetailStatus Status { get; set; }

        public string Description {  get; set; }

        public int BookingID {  get; set; }

        public Booking Booking { get; set; }
    }
}

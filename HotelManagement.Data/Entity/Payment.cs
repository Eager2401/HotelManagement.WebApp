using HotelManagement.Data.Enums;

namespace HotelManagement.Data.Entity
{
    public class Payment
    {
        public int PaymentID { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }

        public string PaymentMethod { get; set; }

        public PaymentStatus PaymentStatus { get; set; }

        public int BookingID { get; set; }

        public Booking Booking { get; set; }
    }
}
namespace HotelManagement.Data.Entity
{
    public class Booking
    {
        public int BookingId { get; set; }

        public DateTime BookingDate { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public int NumberCustomer {  get; set; }

        public int CustomerID { get; set; }
        public int RoomID { get; set; }

        public Customer Customer { get; set; }
        public Room Room { get; set; }
        public Payment Payment { get; set; }
        public ICollection<BookingDetail> BookingDetail { get; set; }
    }
}
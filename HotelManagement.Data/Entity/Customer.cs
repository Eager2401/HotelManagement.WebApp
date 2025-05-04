namespace HotelManagement.Data.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentifyCode { get; set; }
        public string Address { get; set; }
        public string email { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }

        public int AccountID { get; set; }
        public int CustomerTypeID { get; set; }

        public CustomerType CustomerType { get; set; }
        public Account Account { get; set; }
        public ICollection<Booking> Booking { get; set; }
        public ICollection<ServiceDetail> ServiceDetail { get; set; }
    }
}
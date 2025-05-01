namespace HotelManagement.Data.Entity
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int StaffID { get; set; }
        public int CustomerID { get; set; }

        public Staff Staff { get; set; }
        public Customer Customer { get; set; }

        public ICollection<ServiceDetail> ServiceDetails { get; set; }
    }
}
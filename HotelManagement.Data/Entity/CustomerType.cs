namespace HotelManagement.Data.Entity
{
    public class CustomerType
    {
        public int CustomerTypeID { get; set; }
        public string CustomerTypesName { get; set; }
        public string Description { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
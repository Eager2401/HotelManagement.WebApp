namespace HotelManagement.Data.Entity
{
    public class IventoryItem
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Supplier { get; set; }

        public int StaffID { get; set; }

        public Staff Staff { get; set; }
    }
}
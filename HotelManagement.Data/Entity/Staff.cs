namespace HotelManagement.Data.Entity
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateOnly HireDate { get; set; }
        public decimal Salary { get; set; }

        public int StaffTypeID { get; set; }

        public StaffType StaffType { get; set; }

        public virtual ICollection<Room> Room { get; set; }
        public virtual ICollection<IventoryItem> Iventory { get; set; }
        public virtual ICollection<Service> Service { get; set; }
    }
}
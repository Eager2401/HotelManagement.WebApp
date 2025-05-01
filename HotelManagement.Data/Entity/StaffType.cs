namespace HotelManagement.Data.Entity
{
    public class StaffType
    {
        public int StaffTypeID { get; set; }
        public string StaffTypeName { get; set; }
        public string StaffDescription { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }
    }
}
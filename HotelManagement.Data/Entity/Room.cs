using HotelManagement.Data.Enums;

namespace HotelManagement.Data.Entity
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public Status Status { get; set; }
        public int StaffID { get; set; }
        public int RoomTypeID { get; set; }

        public Staff Staff { get; set; }
        public RoomType RoomType { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
    }
}
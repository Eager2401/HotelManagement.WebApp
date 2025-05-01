namespace HotelManagement.Data.Entity
{
    public class RoomType
    {
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerNight { get; set; }

        public virtual ICollection<Room> Room { get; set; }
    }
}
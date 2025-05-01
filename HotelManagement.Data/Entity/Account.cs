using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Data.Entity
{
    public class Account
    {
        public int AccountID { get; set; }

        public string AccountName { get; set; }

        public string AccountPass { get; set; }

        public DateOnly CreatedAt { get; set; }

        public string Email { get; set; }

        public Customer Customer { get; set; }

        public ICollection<LinkRole> LinkRole { get; set; }
    }
}
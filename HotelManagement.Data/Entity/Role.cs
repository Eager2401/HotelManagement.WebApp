using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data.Entity
{
    public class Role
    {
        public int RoleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Account> Account { get; set; }
    }
}

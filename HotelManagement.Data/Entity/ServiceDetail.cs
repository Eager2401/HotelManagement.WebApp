using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data.Entity
{
    public class ServiceDetail
    {
        public int ServiceDetailID { get; set; }

        public int UseNumber { get; set; }

        public decimal TotalPrice { get; set; }

        public string Memo {  get; set; }

        public int ServiceID { get; set; }

        public Service Service { get; set; }

    }
}

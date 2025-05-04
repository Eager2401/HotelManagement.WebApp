using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data.Enums
{
    public enum BookingDetailStatus
    {
        Confirmed = 0, //Đã xác nhận
        CheckedIn = 1, //Đã nhận phòng
        CheckedOut = 2, //Đã trả phòng
        Cancelled = 3, //Phòng bị hủy
        Pending = 4, //Chờ xác nhận
        Guaranted = 5, //Đã thanh toán trước
        NoShow =6 //Khách không đến
    }
}

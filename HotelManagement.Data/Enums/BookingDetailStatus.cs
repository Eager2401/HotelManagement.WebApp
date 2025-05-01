using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data.Enums
{
    public enum BookingDetailStatus
    {
        Confirmed, //Đã xác nhận
        CheckedIn, //Đã nhận phòng
        CheckedOut, //Đã trả phòng
        Cancelled, //Phòng bị hủy
        Pending, //Chờ xác nhận
        Guaranted, //Đã thanh toán trước
        NoShow //Khách không đến
    }
}

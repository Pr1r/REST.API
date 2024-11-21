using HotelBookingAPI.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingAPI.Controllers
{
    public interface IHotelBookingController
    {
        JsonResult CreateEdit(HotelBooking booking);
        JsonResult Delete(int id);
        JsonResult Get(int id);
    }
}
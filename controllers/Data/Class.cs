using Microsoft.EntityFrameworkCore;
using HotelBookingAPI.Controllers.Models;

namespace HotelBookingAPI.Controllers.Data
{
    public class ApiContext : DbContext
    {

        public DbSet<HotelBooking> Bookings { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {


        }


    }
}

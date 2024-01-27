using BookingTrips.Data.DTOs;
using BookingTrips.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookingTrips.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        public BookingsService _bookingsService;

        public BookingsController(BookingsService bookingsService)
        {
            _bookingsService = bookingsService;
        }

        [HttpPost]
        public IActionResult CreateBooking(BookingInformationDTO bookingDTO)
        {
            _bookingsService.CreateBooking(bookingDTO);
            return Ok(bookingDTO);
        }
    }
}

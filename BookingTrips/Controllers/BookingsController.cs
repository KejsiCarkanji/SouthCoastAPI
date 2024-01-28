using BookingTrips.Data.DTOs;
using BookingTrips.Data.Models;
using BookingTrips.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            BookingInformation booking= _bookingsService.CreateBooking(bookingDTO);
            return Ok(booking.ID);
        }

        [HttpGet]
        public IActionResult GetBookings()
        {
            List<BookingInformation> bookings = _bookingsService.GetBookings();
            return Ok(bookings);
        }
    }
}

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
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Validation Errors:");
                foreach (var modelError in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(modelError.ErrorMessage);
                }
                return BadRequest(ModelState);
            }
            _bookingsService.CreateBooking(bookingDTO);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetBookings()
        {
            List<BookingInformation> bookings = _bookingsService.GetBookings();
            return Ok(bookings);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            try
            {
                _bookingsService.DeleteBooking(id);
                return Ok("Booking cancelled!");
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}

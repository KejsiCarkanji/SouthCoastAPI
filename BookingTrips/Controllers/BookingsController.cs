using BookingTrips.Data;
using BookingTrips.Data.DTOs;
using BookingTrips.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace BookingTrips.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private AppDbContext _context;
        public BookingsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("createBooking")]
        public IActionResult CreateBooking(BookingInformationDTO bookingDTO)
        {
            var newBooking = new BookingInformation
            {
                Name = bookingDTO.Name,
                Surname = bookingDTO.Surname,
                BookingDate = bookingDTO.BookingDate,
                TripName = bookingDTO.TripName,
                DepartureTime = bookingDTO.DepartureTime,
                EmailAddress = bookingDTO.EmailAddress,
                PhoneNumber = bookingDTO.PhoneNumber,
                NumberOfAdults = bookingDTO.NumberOfAdults,
                NumberOfKids = bookingDTO.NumberOfKids
            };

            _context.BookingInformation.Add(newBooking);
            _context.SaveChanges();

            return Ok(bookingDTO);
        }

        [HttpGet("GetBookings")]
        public IActionResult GetBookings()
        {
            var allBookings = _context.BookingInformation.ToList();
            return Ok(allBookings);
        }


    }
}

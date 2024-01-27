using BookingTrips.Data;
using BookingTrips.Data.DTOs;
using BookingTrips.Data.Models;
using BookingTrips.Data.Services;
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

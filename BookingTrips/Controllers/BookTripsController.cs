using BookingTrips.Data.DTOs;
using BookingTrips.Data.Models;
using BookingTrips.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingTrips.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTripsController : ControllerBase
    {
        public BookTripsService _bookTripsService;

        public BookTripsController(BookTripsService bookTripsService)
        {
            _bookTripsService = bookTripsService;
        }

        
        [HttpGet]
        public IActionResult GetTrips()
        {
            List<BookTripsInformation> trips = _bookTripsService.GetTrips();
            return Ok(trips);
        }
    }
}

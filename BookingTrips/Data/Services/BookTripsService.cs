using BookingTrips.Data.DTOs;
using BookingTrips.Data.Models;

namespace BookingTrips.Data.Services
{
    public class BookTripsService
    {
        private AppDbContext _context;
        public BookTripsService(AppDbContext context)
        {

            _context = context;

        }

       

        public List<BookTripsInformation> GetTrips()
        {
            var trips = _context.BookTripsInformation.ToList();

            if (trips == null)
            {
                return null;
            }

            return trips;
        }
    }
}
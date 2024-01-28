using BookingTrips.Data.DTOs;
using BookingTrips.Data.Models;

namespace BookingTrips.Data.Services
{
    public class BookingsService
    {
        private AppDbContext _context;
        public BookingsService(AppDbContext context)
        {

            _context = context;

        }

        public BookingInformation CreateBooking(BookingInformationDTO bookingDTO)
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
            return newBooking;

        }

        public List<BookingInformation> GetBookings()
        {
            var bookings = _context.BookingInformation.ToList();

            if (bookings == null)
            {
                return null; 
            }

            return bookings;
        }
    }
}

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

        public void CreateBooking(BookingInformationDTO bookingDTO)
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
        }

        public BookingInformationDTO GetBookingById(int id)
        {
            var booking = _context.BookingInformation.FirstOrDefault(n => n.ID == id);

            if (booking == null)
            {
                return null; 
            }

            
            var bookingDto = new BookingInformationDTO
            {
                Name = booking.Name,
                Surname = booking.Surname,
                BookingDate = booking.BookingDate,
                TripName = booking.TripName,
                DepartureTime = booking.DepartureTime,
                EmailAddress = booking.EmailAddress,
                PhoneNumber = booking.PhoneNumber,
                NumberOfAdults = booking.NumberOfAdults,
                NumberOfKids = booking.NumberOfKids
            };

            return bookingDto;
        }
    }
}

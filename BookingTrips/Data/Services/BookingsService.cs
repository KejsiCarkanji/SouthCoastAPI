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
    }

  
    public class ContactsService
    {
        private AppDbContext _context;

        public ContactsService(AppDbContext context)
        {

            _context = context;

        }

        public void CreateContact(ContactsInformationDTO contactDTO)
        {
            var newContact = new ContactsInformation
            {
                Name = contactDTO.Name,
                EmailAddress = contactDTO.EmailAddress,
                PhoneNumber = contactDTO.PhoneNumber,
                Query = contactDTO.Query



            };
            _context.ContactsInformation.Add(newContact);
            _context.SaveChanges();

        }
    }

}

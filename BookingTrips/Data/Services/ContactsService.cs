using BookingTrips.Data.DTOs;
using BookingTrips.Data.Models;

namespace BookingTrips.Data.Services
{

    public class ContactsService
    {
        private AppDbContext _context;

        public ContactsService(AppDbContext context)
        {

            _context = context;

        }

        public ContactsInformation CreateContact(ContactsInformationDTO contactDTO)
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
            return newContact;

        }
    }

}
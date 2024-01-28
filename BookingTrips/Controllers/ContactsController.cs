using BookingTrips.Data.DTOs;
using BookingTrips.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookingTrips.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ContactsController : ControllerBase
    {
        public ContactsService _contactsService;


        public ContactsController(ContactsService contactsService)
        {
            _contactsService= contactsService;
        }

        [HttpPost]

        public IActionResult CreateContact(ContactsInformationDTO contactDTO)
        {
            _contactsService.CreateContact(contactDTO);
            return Ok(contactDTO);
        }
    }
}

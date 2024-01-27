using System.ComponentModel.DataAnnotations;

namespace BookingTrips.Data.Models
{
    public class BookingInformation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BookingDate { get; set; }
        public string TripName { get; set; }
        public string DepartureTime { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int NumberOfAdults { get; set; }
        public int? NumberOfKids { get; set; }
    }
}

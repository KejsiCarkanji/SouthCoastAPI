using System.ComponentModel.DataAnnotations;

namespace BookingTrips.Data.DTOs
{
    public class BookingInformationDTO
    {
        [Required(ErrorMessage = "The Name field is required.")]
        [MinLength(2, ErrorMessage = "Name must contain at least 2 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Surname field is required.")]
        [MinLength(2, ErrorMessage = "Surame must contain at least 2 characters")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "The Date field is required.")]
        public DateOnly BookingDate { get; set; }

        [Required(ErrorMessage = "The Trip Name field is required.")]
        public string TripName { get; set; }

        [Required(ErrorMessage = "The Departure Time field is required.")]
        public string DepartureTime { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "The Phone Number field is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Enter 10-digit phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "The Number of Adults field is required.")]
        public int NumberOfAdults { get; set; }
        public int? NumberOfKids { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BookingTrips.Data.Models
{
    public class BookTripsInformation
    {
        [Key]
        public int TripID { get; set; }
        public string TripName { get; set; }
        public string MeetingPoint { get; set; }
        public string WeVisit { get; set; }
        public string Departure { get; set;}
        public string Duration { get; set; }
        public string Price { get;set; }
    }
}
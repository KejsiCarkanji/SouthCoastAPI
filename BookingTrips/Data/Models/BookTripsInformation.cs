using System.ComponentModel.DataAnnotations;

namespace BookingTrips.Data.Models
{
    public class BookTripsInformation
    {
        
        public string TripName { get; set; }
        public string MeetingPoint { get; set; }
        public string WeVisit { get; set; }
        public string Departure { get; set;}
        public string Price { get;set; }
        [Key]
        public int TripID { get; set; }
    }
}
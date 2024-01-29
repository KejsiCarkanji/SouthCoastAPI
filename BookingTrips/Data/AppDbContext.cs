using BookingTrips.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingTrips.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<BookingInformation> BookingInformation { get; set; }
        public DbSet<BookTripsInformation> BookTripsInformation { get; set; }
        public DbSet<ContactsInformation> ContactsInformation { get; set; }
    }
}


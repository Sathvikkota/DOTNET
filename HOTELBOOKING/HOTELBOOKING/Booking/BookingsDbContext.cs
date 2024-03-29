using Microsoft.EntityFrameworkCore;

namespace HOTELBOOKING.Booking
{
    public class BookingsDbContext: DbContext
    {
        public BookingsDbContext(DbContextOptions<BookingsDbContext> actions) 
            : base(actions)
        {

        }
        public DbSet<Bookings> Bookings { get; set; }
    }
}

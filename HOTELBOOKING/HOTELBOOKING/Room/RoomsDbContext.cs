using Microsoft.EntityFrameworkCore;
namespace HOTELBOOKING.Room
{
    public class RoomsDbContext:DbContext
    {
        public RoomsDbContext(DbContextOptions<RoomsDbContext> choices) 
            : base(choices) 
        {

        }
        public DbSet<Rooms> Rooms { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace HOTELBOOKING.Payment
{
    public class PaymentsDbContext:DbContext
    {
        public PaymentsDbContext(DbContextOptions<PaymentsDbContext> lists) 
            : base(lists)
        {
            
        }
        public DbSet<Payments> Payment { get; set; }
    }
}

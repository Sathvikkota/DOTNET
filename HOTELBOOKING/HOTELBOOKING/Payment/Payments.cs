using System.ComponentModel.DataAnnotations;
namespace HOTELBOOKING.Payment
{
    public class Payments
    {
        public int Id { get; set; }
        [Required]
        public string GuestName { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public decimal Amount { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
namespace HOTELBOOKING.Room
{
    public class Rooms
    {
        public int Id { get; set; }
        [Required]
        public string RoomType { get; set; }
        [Required]
        public string Status { get; set; } 
    }
}

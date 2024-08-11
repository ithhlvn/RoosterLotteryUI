using System.ComponentModel.DataAnnotations;

namespace RoosterLottery.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string FullName { get; set; }
        public DateTime? DoB { get; set; }
        public string Phone { get; set; }
    }
}

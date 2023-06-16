using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playerdle.Infrastructure.Model
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string Position { get; set; }
        [Required]
        public int Number { get; set; }
        public int? TeamId { get; set; }
        [ForeignKey(nameof(TeamId))]
        public Team? Team { get; set; }
        [Required]
        public string Nationallity { get; set; } = null!;
        [Required]
        public int Age { get; set; }
        [Required]
        public byte[] Image { get; set; }




    }
}

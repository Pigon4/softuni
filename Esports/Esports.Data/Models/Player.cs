using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esports.Data.Models
{
    public class Player
    {
        public Player()
        {
            
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string Nickname { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string Nationality { get; set; } = null!;

        [Required]
        [Range(16, int.MaxValue)]
        public int Age { get; set; }
        [Required]
        [MaxLength(3)]
        public string Position { get; set; } = null!;
        [Required]
        public byte[] Image { get; set; }
        public Guid TeamId { get; set; }
        public Team Team { get; set; }
    }
}

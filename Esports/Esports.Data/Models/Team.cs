using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esports.Data.Models
{
    public class Team
    {
        public Team()
        {
            Players = new HashSet<Player>();
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(50)]
        public string CountryOrigin { get; set; } = null!;
        [Required]
        public byte[] Logo { get; set; }

        public int Titles { get; set; }
        public ICollection<Player> Players { get; set; }

    }
}

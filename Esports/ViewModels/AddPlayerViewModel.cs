using Esports.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class AddPlayerViewModel
    {
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

        public Teams Team { get; set; }
    }
}

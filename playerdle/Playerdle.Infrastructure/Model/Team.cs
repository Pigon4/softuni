using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playerdle.Infrastructure.Model
{
    public class Team
    {
        public Team()
        {
               Players = new List<Player>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public byte[] Logo { get; set; }   
        [Required]
        public ICollection<Player> Players { get; set; }
    }
}

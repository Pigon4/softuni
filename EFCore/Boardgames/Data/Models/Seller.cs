using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.Data.Models
{
    public class Seller
    {
        public Seller()
        {
            BoardgamesSellers = new HashSet<BoardgameSeller>();
        }
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Address { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [RegularExpression(@"\b[www.]{4}[a-zA-Z0-9-]*.{1}[com]+\b")]
        public string Website { get; set; }
        public ICollection<BoardgameSeller> BoardgamesSellers { get; set; }
    }
}

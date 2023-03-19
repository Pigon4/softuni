using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models
{
    public class Song 
    {
        public Song()
        {
            SongPerformers = new HashSet<SongPerformer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime CreatedOn { get; set; }
        public Genre Genre { get; set; }
        public decimal Price { get; set; }
        public int? AlbumId { get; set; }
        public Album? Album { get; set; }
        public int WriterId { get; set; }
        public Writer? Writer { get; set; }
        public HashSet<SongPerformer> SongPerformers { get; set; }

    }

    public enum Genre {
        Blues, 
        Rap, 
        PopMusic, 
        Rock, 
        Jazz
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models
{
    public class Album
    {
        public Album()
        {
            Songs = new HashSet<Song>();
            Price = this.Songs.Sum(x => x.Price);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public int? ProducerId { get; set; }
        public Producer? Producer { get; set; }
        public HashSet<Song> Songs { get; set; }
    }
}

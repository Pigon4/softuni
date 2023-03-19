using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models
{
    public class Producer
    {
        public Producer()
        {
            Albums = new HashSet<Album>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Pseudonym { get; set; }
        public string? PhoneNumber { get; set; }
        public HashSet<Album> Albums { get; set; }

    }
}

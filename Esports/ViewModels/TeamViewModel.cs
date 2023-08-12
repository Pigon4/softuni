using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class TeamViewModel
    {
        public TeamViewModel()
        {
            Players = new List<PlayerViewModel>();
        }
        
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(50)]
        public string CountryOrigin { get; set; } = null!;
        [Required]
        public byte[] Logo { get; set; }

        public int Titles { get; set; }
        public ICollection<PlayerViewModel> Players { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;


namespace ViewModels
{
    public class PlayerViewModel
    {
        public string Name { get; set; } = null!;
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
        public TeamViewModel? Team { get; set; }
    }
}

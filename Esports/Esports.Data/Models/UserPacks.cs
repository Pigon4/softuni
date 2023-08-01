using Esports.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Esports.Data.Models
{
    public class UserPacks
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        [Required]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int PackId { get; set; }
    }
}

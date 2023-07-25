using Esports.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esports.Data.Models
{
    public class UserTeams
    {
        [Required]
        [Key]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }
        public Guid TopId { get; set; } 
        public Guid JngId { get; set; }
        public Guid MidId { get; set; }
        public Guid AdcId { get; set; }
        public Guid SupId { get; set; }

        
    }
}

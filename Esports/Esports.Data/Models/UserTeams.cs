using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esports.Data.Models
{
    public class UserTeams
    {
        [Required]
        [Key]
        public Guid UserId { get; set; }
        public Guid TopId { get; set; } 
        public Guid JngId { get; set; }
        public Guid MidId { get; set; }
        public Guid AdcId { get; set; }
        public Guid SupId { get; set; }

        
    }
}

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
        [ForeignKey(nameof(Top))]
        public Guid TopId { get; set; }
        public Players Top { get; set; }
        [ForeignKey(nameof(Jng))]
        public Guid JngId { get; set; }
        public Players Jng { get; set; }
        [ForeignKey(nameof(Mid))]
        public Guid MidId { get; set; }
        public Players Mid { get; set; }
        [ForeignKey(nameof(Adc))]
        public Guid AdcId { get; set; }
        public Players Adc { get; set; }
        [ForeignKey(nameof(Sup))]
        public Guid SupId { get; set; }
        public Players Sup { get; set; }


    }
}

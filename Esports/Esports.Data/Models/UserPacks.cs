using Esports.DataModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esports.Data.Models
{
    public class UserPacks
    {
        [ForeignKey(nameof(User))]
        [Required]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int PackId { get; set; }
    }
}

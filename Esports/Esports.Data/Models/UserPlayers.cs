﻿using Esports.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esports.Data.Models
{
    public class UserPlayers
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        [Required]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }

        [ForeignKey(nameof(Player))]
        [Required]
        public Guid PlayerId { get; set; }
        public Player Player { get; set; }

    }
}

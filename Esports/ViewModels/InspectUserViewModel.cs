﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class InspectUserViewModel
    {
        public InspectUserViewModel()
        {
            Team = new List<PlayerViewModel>();
        }
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public int Points { get; set; }

        public List<PlayerViewModel> Team { get; set; }
    }
}

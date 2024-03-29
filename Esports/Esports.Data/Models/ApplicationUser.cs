﻿using Esports.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esports.Data.Helpers;
using Services;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esports.DataModels
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        private PackHelper packHelper = new PackHelper();
        public ApplicationUser() 
        {
            Points = 0;
            HasClaimedFreeReward = false;
            Packs = new List<UserPacks>();
            UserTeam = new HashSet<UserTeams>();
        }

        public int Points { get; set; }

        public bool HasClaimedFreeReward { get; set; }

        public List<UserPlayers> UserPlayers { get; set; }

        public IEnumerable<UserTeams> UserTeam { get; set; }

        public List<UserPacks> Packs { get; set; }


    }
}

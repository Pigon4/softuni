using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class UserPacksViewModel
    {
        public Dictionary<Guid, List<int>> UserPacks { get; set; }

        [Required]
        public bool HasClaimedFreePack { get; set; } = false;

    }
}

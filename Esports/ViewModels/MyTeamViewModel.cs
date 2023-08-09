using Esports.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class MyTeamViewModel
    {
        public Guid UserId { get; set; }
        public PlayerViewModel? Top { get; set; }
        public PlayerViewModel? Jng { get; set; }
        public PlayerViewModel? Mid { get; set; }
        public PlayerViewModel? Adc { get; set; }
        public PlayerViewModel? Sup { get; set; }
    }
}

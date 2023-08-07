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
        public Guid TopId { get; set; }
        public Guid JngId { get; set; }
        public Guid MidId { get; set; }
        public Guid AdcId { get; set; }
        public Guid SupId { get; set; }
    }
}

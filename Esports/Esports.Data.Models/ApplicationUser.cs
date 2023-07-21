using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esports.DataModels
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser() 
        {

        }


    }
}

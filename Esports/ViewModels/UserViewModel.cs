using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class UserViewModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public int Points { get; set; }
    }
}

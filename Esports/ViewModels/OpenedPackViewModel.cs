
using Esports.Data.Models;

namespace ViewModels
{
    public class OpenedPackViewModel
    {
        public OpenedPackViewModel()
        {
            Players = new List<PlayerViewModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
       public List<PlayerViewModel> Players { get; set; }
    }
}

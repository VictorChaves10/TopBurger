
using System.Collections.Generic;
using TopBurgers.Models;

namespace TopBurgers.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}

using System.Collections;
using System.Collections.Generic;
using TopBurgers.Models;

namespace TopBurgers.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}

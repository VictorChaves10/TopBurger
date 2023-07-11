using System.Collections.Generic;
using TopBurgers.Models;

namespace TopBurgers.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}

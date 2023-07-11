using System.Collections.Generic;
using TopBurgers.Context;
using TopBurgers.Models;
using TopBurgers.Repositories.Interfaces;

namespace TopBurgers.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}

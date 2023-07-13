using RafaLanches.Context;
using RafaLanches.Models;
using RafaLanches.Repositories.Interfaces;

namespace RafaLanches.Repositories
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

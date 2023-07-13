using Microsoft.EntityFrameworkCore;
using RafaLanches.Context;
using RafaLanches.Models;
using RafaLanches.Repositories.Interfaces;

namespace RafaLanches.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c=> c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
                                                        .Where(l=>l.IsLanchePreferido)
                                                        .Include(c=>c.Categoria);

        Lanche ILancheRepository.GetLancheById(int id)
        {
            return _context.Lanches.FirstOrDefault(l=> l.LancheId == id);
        }
    }
}

using DesafioSprint03_Web.Models;
using DesafioSprint03_Web.Data;
using DesafioSprint03_Web.Repositories;
using Microsoft.EntityFrameworkCore;
namespace DesafioSprint03_Web.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Lanche>> ListarTodos()
        {
            return await _context.Lanches.Include(I => I.ItensPedido).ToListAsync();

        }
        public async Task Adicionar(Lanche lanche)
        {
            _context.Lanches.AddAsync(lanche);
            await _context.SaveChangesAsync();
        }

        public async Task<Lanche?> BuscarPorId(int id)
        {
            return await _context.Lanches.FindAsync(id);
        }

        public async Task Atulizar(Lanche lanche)
        {
            _context.Lanches.Update(lanche);
            await _context.SaveChangesAsync();
        }


        public async Task Remover(Lanche lanche)
        {
            _context.Lanches.Remove(lanche);
            await _context.SaveChangesAsync();
        }

    }
}

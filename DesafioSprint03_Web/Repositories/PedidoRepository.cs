using DesafioSprint03_Web.Models;
using DesafioSprint03_Web.Data;
using DesafioSprint03_Web.Repositories;
using Microsoft.EntityFrameworkCore;
namespace DesafioSprint03_Web.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _context;
        public PedidoRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Pedido>> ListarTodos()
        {
            return await _context.Pedidos.Include(I => I.ItensPedido).ToListAsync();
        }
        public async Task Adicionar(Pedido pedido)
        {
            _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }
    
    }
}

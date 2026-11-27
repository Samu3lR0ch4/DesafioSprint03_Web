using DesafioSprint03_Web.Data;
using DesafioSprint03_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioSprint03_Web.Repositories
{
        public class ItemPedidoRepository : IItemPedidoRepository
        {
            private readonly AppDbContext _context;

            public ItemPedidoRepository(AppDbContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<ItemPedido>> ListarTodos()
            {
                return await _context.ItensPedido
                .Include(i => i.Lanche)
                .ToListAsync();
            }

            public async Task<ItemPedido?> BuscarPorId(int id)
            {
                return await _context.ItensPedido
                .Include(i => i.Lanche)
                .FirstOrDefaultAsync(i => i.id == id);
            }

            public async Task Adicionar(ItemPedido itemPedido)
            {
                await _context.ItensPedido.AddAsync(itemPedido);
                await _context.SaveChangesAsync();
            }

            public async Task Atualizar(ItemPedido itemPedido)
            {
                _context.ItensPedido.Update(itemPedido);
                await _context.SaveChangesAsync();
            }

            public async Task Remover(ItemPedido itemPedido)
            {
                _context.ItensPedido.Remove(itemPedido);
                await _context.SaveChangesAsync();
            }
        }

    }


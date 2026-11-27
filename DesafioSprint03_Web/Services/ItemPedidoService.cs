using DesafioSprint03_Web.Repositories;
using DesafioSprint03_Web.Models;
namespace DesafioSprint03_Web.Services
{
    public class ItemPedidoService : IItemPedidoService
    {
        private readonly IItemPedidoRepository _itemPedidoRepository;

        public ItemPedidoService(IItemPedidoRepository itemPedidoRepository)
        {
            _itemPedidoRepository = itemPedidoRepository;
        }

        public async Task<IEnumerable<ItemPedido>> ListarTodos()
        {
            return await _itemPedidoRepository.ListarTodos();
        }
        public async Task Criar(ItemPedido itemPedido)
        {
           var ItemPedido = new ItemPedido
           {
               id = itemPedido.id,
               Quantidade = itemPedido.Quantidade,
               PrecoUnitario = itemPedido.PrecoUnitario,
               LancheId = itemPedido.LancheId
           };
            await _itemPedidoRepository.Adicionar(ItemPedido);
        }
    }
}

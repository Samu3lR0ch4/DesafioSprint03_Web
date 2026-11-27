using DesafioSprint03_Web.Models;
namespace DesafioSprint03_Web.Services
{
    public interface IItemPedidoService
    {
        Task<IEnumerable<ItemPedido>> ListarTodos();

        Task Criar(ItemPedido itemPedido);

    }
}

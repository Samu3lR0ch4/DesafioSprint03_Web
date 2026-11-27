using DesafioSprint03_Web.Models;
namespace DesafioSprint03_Web.Repositories
{
    public interface IItemPedidoRepository
    {
        Task<IEnumerable<ItemPedido>> ListarTodos();
        Task Adicionar(ItemPedido itemPedido);
    }
}

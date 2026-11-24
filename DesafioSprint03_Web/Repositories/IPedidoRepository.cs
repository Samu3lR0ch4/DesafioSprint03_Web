using DesafioSprint03_Web.Models;
namespace DesafioSprint03_Web.Repositories
{
    public interface IPedidoRepository
    {
        Task<IEnumerable<Pedido>> ListarTodos();
        Task Adicionar(Pedido pedido);
    }
}

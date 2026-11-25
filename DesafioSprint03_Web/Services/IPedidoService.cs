using DesafioSprint03_Web.Models;
using DesafioSprint03_Web.DTOs;
namespace DesafioSprint03_Web.Services
{
    public interface IPedidoService
    {

        Task<IEnumerable<Pedido>> ListarTodos();

        Task Criar(PedidoDTO pedidoDTO);
    }
}

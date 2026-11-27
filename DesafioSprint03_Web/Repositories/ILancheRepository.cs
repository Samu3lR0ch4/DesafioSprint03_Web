using DesafioSprint03_Web.DTOs;
using DesafioSprint03_Web.Models;
namespace DesafioSprint03_Web.Repositories
{
    public interface ILancheRepository
    {

        Task<IEnumerable<Lanche>>ListarTodos();

        Task Adicionar(Lanche lanche);

        Task<Lanche?> BuscarPorId(int id);

        Task Atulizar(Lanche lanche);

        Task Remover(Lanche lanche);
    }
}

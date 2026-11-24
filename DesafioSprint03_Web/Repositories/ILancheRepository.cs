using DesafioSprint03_Web.Models;
namespace DesafioSprint03_Web.Repositories
{
    public interface ILancheRepository
    {

        Task<IEnumerable<Lanche>>ListarTodos();

        Task Adicionar(Lanche lanche);
    }
}

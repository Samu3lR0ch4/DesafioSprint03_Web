using DesafioSprint03_Web.Models;
using DesafioSprint03_Web.DTOs;
namespace DesafioSprint03_Web.Services
{
    public interface ILancheService
    {
        Task <IEnumerable<Lanche>> ListarTodos();

        Task Criar(LancheDTO lancheDTO);
    }
}

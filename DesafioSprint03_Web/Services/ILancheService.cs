using DesafioSprint03_Web.Models;
using DesafioSprint03_Web.DTOs;
namespace DesafioSprint03_Web.Services
{
    public interface ILancheService
    {
        Task <IEnumerable<Lanche>> ListarTodos();
        Task Criar(LancheDTO lancheDTO);

        Task Atualizar(LancheDTO lancheDTO, int id);

        Task Remover(int id);


    }
}

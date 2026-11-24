using DesafioSprint03_Web.Models;
namespace DesafioSprint03_Web.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> ListarTodos();

        Task Adicionar(Usuario usuario);
    }
}

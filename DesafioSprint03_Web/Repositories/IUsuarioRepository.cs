using DesafioSprint03_Web.Models;
namespace DesafioSprint03_Web.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> ListarTodos();
        Task<Usuario?> BuscarPorNome(string nome);
        Task<Usuario?> BuscarPorEmail(string email);
        Task Adicionar(Usuario usuario);


    }
}

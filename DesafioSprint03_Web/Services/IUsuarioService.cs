using DesafioSprint03_Web.Models;
using DesafioSprint03_Web.DTOs;
namespace DesafioSprint03_Web.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> ListarTodos();

        Task Criar(UsuarioDTO usuarioDTO);

    }
}

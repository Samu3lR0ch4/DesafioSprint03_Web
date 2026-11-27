using DesafioSprint03_Web.DTOs;

namespace DesafioSprint03_Web.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioResponseDTO>> ListarTodos();
        Task Criar(UsuarioDTO dto);
    }
}

using DesafioSprint03_Web.Models;
using DesafioSprint03_Web.DTOs;
using DesafioSprint03_Web.Repositories;
namespace DesafioSprint03_Web.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<IEnumerable<Usuario>> ListarTodos()
        {
            return await _usuarioRepository.ListarTodos();
        }

        public async Task Criar(UsuarioDTO usuarioDTO)
        {
            var usuario = new Usuario
            {
                Nome = usuarioDTO.Nome,
                Email = usuarioDTO.Email,
                Senha = usuarioDTO.Senha,
                Telefone = usuarioDTO.Telefone
            };
            await _usuarioRepository.Adicionar(usuario);
        }

    }
}

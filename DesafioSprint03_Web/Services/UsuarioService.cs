using DesafioSprint03_Web.DTOs;
using DesafioSprint03_Web.Models;
using DesafioSprint03_Web.Repositories;
using Microsoft.AspNetCore.Identity;
namespace DesafioSprint03_Web.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repo;
        private readonly PasswordHasher<Usuario> _hasher = new();

        public UsuarioService(IUsuarioRepository repo) => _repo = repo;

        public async Task<IEnumerable<UsuarioResponseDTO>> ListarTodos()
            => (await _repo.ListarTodos()).Select(u => new UsuarioResponseDTO
            {
                Id = u.Id,
                Nome = u.Nome,
                Email = u.Email,
                Telefone = u.Telefone,
                perfil = u.perfil
            });

        public async Task Criar(UsuarioDTO dto)
        {
            if (await _repo.BuscarPorNome(dto.Nome) != null)
                throw new InvalidOperationException("Já existe um usuário com esse nome");
            if (await _repo.BuscarPorEmail(dto.Email) != null)
                throw new InvalidOperationException("Já existe um usuário com esse e-mail");

            var usuario = new Usuario
            {
                Nome = dto.Nome,
                Email = dto.Email,
                Telefone = dto.Telefone,
                perfil = dto.perfil
            };
            usuario.Senha = _hasher.HashPassword(usuario, dto.Senha); // hash, nunca texto puro
            await _repo.Adicionar(usuario);
        }


    }
}

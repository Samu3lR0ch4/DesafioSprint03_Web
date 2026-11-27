using DesafioSprint03_Web.DTOs;
using DesafioSprint03_Web.Models;
using DesafioSprint03_Web.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace DesafioSprint03_Web.Services
{
    public class AuthService : IAuthService     {


        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IConfiguration _configuration;

        private readonly PasswordHasher<Usuario> _passwordHasher = new();
        public AuthService(IUsuarioRepository usuarioRepository, IConfiguration configuration)
        {
            _usuarioRepository = usuarioRepository;
            _configuration = configuration;
        }

        public async Task Registrar(RegistroDTO dto)
        {
            var usuarioExistente = await _usuarioRepository.BuscarPorNome(dto.Usuario);
            if (usuarioExistente != null)
            {
                throw new Exception("Usuário já existe");
            }
            var novoUsuario = new Usuario
            {
                Nome = dto.Usuario,
                Email = dto.Email,
                Telefone = dto.Telefone,
                perfil = "Cliente"
            };

            novoUsuario.Senha = _passwordHasher.HashPassword(novoUsuario, dto.Senha);

            await _usuarioRepository.Adicionar(novoUsuario);
        }
        public async Task<string> Login(LoginDTO dto)
        {
            var usuario = await _usuarioRepository.BuscarPorNome(dto.Usuario);
            if (usuario == null)
            {
                throw new UnauthorizedAccessException("Usuário não encontrado");
            }
            var resultadoVerificacao = _passwordHasher.VerifyHashedPassword(usuario, usuario.Senha, dto.Senha);
            if (resultadoVerificacao == PasswordVerificationResult.Failed)
            {
                throw new UnauthorizedAccessException("Senha incorreta");
            }
            // criação do token JWT
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                        new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                        new Claim(ClaimTypes.Name, usuario.Nome, "Admin")
                    }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature),

                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"]
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
            // Aqui você pode gerar um token JWT ou qualquer outro mecanismo de autenticação
            // Para simplificação, vamos apenas retornar uma mensagem de sucesso
        
        }
    }
}

using DesafioSprint03_Web.DTOs;

namespace DesafioSprint03_Web.Services
{
    public interface IAuthService
    {
        Task Registrar(RegistroDTO dto);
        Task <string> Login(LoginDTO dto);
    }
}

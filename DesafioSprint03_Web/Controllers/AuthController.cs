using Microsoft.AspNetCore.Http;
using DesafioSprint03_Web.DTOs;
using Microsoft.AspNetCore.Mvc;
using DesafioSprint03_Web.Services;
namespace DesafioSprint03_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
         public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("registrar")]
        public async Task<IActionResult> Registrar([FromBody] RegistroDTO dto)
        {
            try
            {
                await _authService.Registrar(dto);
                return Ok(new {mensagem = "Usuário registrado com sucesso" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]

        public async Task<IActionResult> Login([FromBody] LoginDTO dto)
        {
            try
            {
                var token = await _authService.Login(dto);
                return Ok(new { token, usuario = dto.Usuario  });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DesafioSprint03_Web.Repositories;
using Microsoft.AspNetCore.Authorization;
using DesafioSprint03_Web.DTOs;
using DesafioSprint03_Web.Services;
namespace DesafioSprint03_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _usuarioService.ListarTodos());

        [Authorize]
        [HttpPost]

        public async Task<IActionResult> Post(UsuarioDTO usuario)
        {
            try
            {
                await _usuarioService.Criar(usuario);
                return Ok("Usuário Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

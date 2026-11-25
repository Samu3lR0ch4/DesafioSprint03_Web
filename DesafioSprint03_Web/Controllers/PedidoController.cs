using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DesafioSprint03_Web.Repositories;
using Microsoft.AspNetCore.Authorization;
using DesafioSprint03_Web.Services;
using DesafioSprint03_Web.DTOs;

namespace DesafioSprint03_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;
        
        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _pedidoService.ListarTodos());

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post(PedidoDTO pedido)
        {
            try
            {
                await _pedidoService.Criar(pedido);
                return Ok("Pedido Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}

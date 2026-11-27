using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DesafioSprint03_Web.Repositories;
using DesafioSprint03_Web.Models;
using DesafioSprint03_Web.Services;
using Microsoft.AspNetCore.Authorization;
namespace DesafioSprint03_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemPedidoController : ControllerBase
    {
        private readonly IItemPedidoService _itemPedidoService;

        public ItemPedidoController(IItemPedidoService itemPedidoService)
        {
            _itemPedidoService = itemPedidoService;
        }
        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _itemPedidoService.ListarTodos());

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post(ItemPedido itemPedido)
        {
            try
            {
                await _itemPedidoService.Criar(itemPedido);
                return Ok("Item do Pedido Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

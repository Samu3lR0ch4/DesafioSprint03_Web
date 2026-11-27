using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DesafioSprint03_Web.Repositories;
using DesafioSprint03_Web.Services;
using DesafioSprint03_Web.DTOs;
using Microsoft.AspNetCore.Authorization;
namespace DesafioSprint03_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanchesController : ControllerBase
    {

        private readonly ILancheService _service;

        public LanchesController(ILancheService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _service.ListarTodos());

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post(LancheDTO lancheDTO)
        {
            try
            {
                await _service.Criar(lancheDTO);
                return Ok("Lanche Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }         
        }
        [Authorize]
        [HttpPut("{id}")]

        public async Task<IActionResult> Put(int id, LancheDTO lancheDTO)
        {
            try
            {
                await _service.Atualizar(lancheDTO, id);
                return Ok("Lanche Atualizado com Sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Authorize]
        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _service.Remover(id);
                return Ok("Lanche Removido com Sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}


 
using DesafioSprint03_Web.Repositories;
using DesafioSprint03_Web.Models;
using DesafioSprint03_Web.DTOs;
namespace DesafioSprint03_Web.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public async Task<IEnumerable<Pedido>> ListarTodos()
        {
            return await _pedidoRepository.ListarTodos();
        }

        public async Task Criar(PedidoDTO pedidoDTO)
        {
            var pedido = new Pedido
            {
                usuarioId = pedidoDTO.usuarioId,
                FormaPagamento = pedidoDTO.FormaPagamento,
                ValorTotal = pedidoDTO.ValorTotal
            };
            await _pedidoRepository.Adicionar(pedido);
        }
    }
}

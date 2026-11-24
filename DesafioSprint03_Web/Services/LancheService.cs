using DesafioSprint03_Web.DTOs;
using DesafioSprint03_Web.Models;
using DesafioSprint03_Web.Repositories;
namespace DesafioSprint03_Web.Services
{
    public class LancheService : ILancheService
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheService(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        public async Task<IEnumerable<Lanche>> ListarTodos()
        {
            return await _lancheRepository.ListarTodos();
        }

        public async Task Criar(LancheDTO lancheDTO)
        {
            var lanche = new Lanche
            {
                nome = lancheDTO.nome,
                descricao = lancheDTO.descricao,
                preco = lancheDTO.preco
            };
            await _lancheRepository.Adicionar(lanche);
        }

    }
}

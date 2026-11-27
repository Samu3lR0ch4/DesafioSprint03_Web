using DesafioSprint03_Web.Models;
using DesafioSprint03_Web.Data;
using Microsoft.EntityFrameworkCore;

namespace DesafioSprint03_Web.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
     
    private readonly AppDbContext _context;
    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Usuario?> BuscarPorNome(string Nome)
    {
        return await _context.Usuarios.FirstOrDefaultAsync(u=> u.Nome == Nome);
    }
    public async Task Adicionar(Usuario usuario)
    {
        await _context.Usuarios.AddAsync(usuario);
        await _context.SaveChangesAsync();
    }
        public async Task<IEnumerable<Usuario>> ListarTodos()
    => await _context.Usuarios.AsNoTracking().ToListAsync();

        public async Task<Usuario?> BuscarPorEmail(string email)
           => await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);




    }

}
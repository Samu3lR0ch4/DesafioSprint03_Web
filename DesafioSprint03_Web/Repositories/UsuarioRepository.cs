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
    public async Task<IEnumerable<Usuario>> ListarTodos()
    {
        return await _context.Usuarios.ToListAsync();
    }
    public async Task Adicionar(Usuario usuario)
    {
        _context.Usuarios.AddAsync(usuario);
        await _context.SaveChangesAsync();
    }
}

}

using Microsoft.EntityFrameworkCore;
using DesafioSprint03_Web.Models;
using System.Security.Cryptography.X509Certificates;

namespace DesafioSprint03_Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}

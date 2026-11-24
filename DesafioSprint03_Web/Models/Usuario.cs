using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace DesafioSprint03_Web.Models
{
    public class Usuario
    {

        public string Id { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string Nome { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Senha { get; set; } = string.Empty;
        public int Telefone { get; set; }

        public string perfil { get; set; } = "Cliente"; 

    }
}

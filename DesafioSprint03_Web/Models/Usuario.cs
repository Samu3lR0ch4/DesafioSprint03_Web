using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;   

namespace DesafioSprint03_Web.Models
{
    public class Usuario
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Senha { get; set; } = string.Empty;

        public string? Telefone { get; set; }

        public string perfil { get; set; } = "Cliente";
    }
}

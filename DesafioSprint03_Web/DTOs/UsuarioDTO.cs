using System.ComponentModel.DataAnnotations;

namespace DesafioSprint03_Web.DTOs
{
    public class UsuarioDTO
    {
      
        [Required]
        [MaxLength(255)]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; } 
        [Required]
        public string Senha { get; set; } 
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string perfil { get; set; } = "Cliente";
    }
}

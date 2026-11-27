using System.ComponentModel.DataAnnotations;

namespace DesafioSprint03_Web.DTOs
{
    public class UsuarioDTO
    {

        [Required, MaxLength(255)]
        public string Nome { get; set; }

        [Required, EmailAddress, MaxLength(255)]
        public string Email { get; set; }
        [Required, MinLength(6)]
        public string Senha { get; set; } 
        [Required]
        public string Telefone { get; set; }
        public string perfil { get; set; } = "Cliente";
    }
    public class UsuarioResponseDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Telefone { get; set; }
        public string perfil { get; set; } = string.Empty;
    }

}

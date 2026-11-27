using System.ComponentModel.DataAnnotations;

namespace DesafioSprint03_Web.DTOs
{
    public class RegistroDTO
    {
        [Required, MaxLength(255)]
        public string Usuario { get; set; } = string.Empty;

        [Required, EmailAddress, MaxLength(255)]
        public string Email { get; set; } = string.Empty;

        [Required, MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres")]
        public string Senha { get; set; } = string.Empty;

        public string? Telefone { get; set; }


    }
}

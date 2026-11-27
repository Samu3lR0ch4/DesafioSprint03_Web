using System.ComponentModel.DataAnnotations;

namespace DesafioSprint03_Web.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "O Usuário é obrigatório para fazer login")]
        public string Usuario { get; set; } = string.Empty;
           
        [Required(ErrorMessage = "A senha é obrigatória para fazer login")]
        public string Senha { get; set; } = string.Empty;
    }
}

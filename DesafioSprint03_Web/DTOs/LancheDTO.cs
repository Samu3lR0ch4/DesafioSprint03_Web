using System.ComponentModel.DataAnnotations;

namespace DesafioSprint03_Web.DTOs
{
    public class LancheDTO
    {
        [Required]
        public string nome { get; set; }
        [Required]
        public string descricao { get; set; }
        [Required]
        public decimal preco { get; set; }
        [Required]
        public bool disponivel { get; set; }
        [Required]
        public string categoria { get; set; }

    }
}

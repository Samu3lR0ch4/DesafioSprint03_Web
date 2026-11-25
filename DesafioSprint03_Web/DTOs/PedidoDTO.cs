using DesafioSprint03_Web.Models;
using System.ComponentModel.DataAnnotations;

namespace DesafioSprint03_Web.DTOs
{
    public class PedidoDTO
    {

        [Required]
        public string usuarioId { get; set; }
        [Required]
        public Usuario? Usuario { get; set; }
        [Required]
        public DateTime DataPedido { get; set; } = DateTime.Now;
        [Required]
        public string Status { get; set; } = "Pendente";

        [Required]
        public string FormaPagamento { get; set; } 

        [Required]

        public decimal ValorTotal { get; set; }
    }
}

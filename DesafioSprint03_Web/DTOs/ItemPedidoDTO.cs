using DesafioSprint03_Web.Models;
using System.ComponentModel.DataAnnotations;

namespace DesafioSprint03_Web.DTOs
{
    public class ItemPedidoDTO
    {
        [Required]
        public int PedidoId { get; set; }
        [Required]
        public int LancheId { get; set; }
        [Required]
        [Range(1,int.MaxValue)]
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

    }
}

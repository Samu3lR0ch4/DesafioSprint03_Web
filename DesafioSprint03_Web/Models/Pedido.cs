using System.ComponentModel.DataAnnotations;

namespace DesafioSprint03_Web.Models
{
    public class Pedido
    {
        public int Id { get; set; }   
        public string usuarioId { get; set; } = string.Empty;
        public Usuario? Usuario { get; set; }
        public DateTime DataPedido { get; set; } = DateTime.Now;     
        public string Status { get; set; } = "Pendente";

        [Required]
        public string FormaPagamento { get; set; } = string.Empty;

        public decimal ValorTotal { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido>();

    }
}

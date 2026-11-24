using System.ComponentModel.DataAnnotations;
namespace DesafioSprint03_Web.Models
{
    public class ItemPedido
    {
        public int id { get; set; }

        public int PedidoId { get; set; }

        public Pedido? Pedido { get; set; }

        public int LancheId { get; set; }

        public Lanche? Lanche { get; set; }

        public int Quantidade { get; set; }

        public decimal PrecoUnitario { get; set; }


    }
}

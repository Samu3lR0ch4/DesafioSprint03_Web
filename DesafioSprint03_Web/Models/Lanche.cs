using System.ComponentModel.DataAnnotations;

namespace DesafioSprint03_Web.Models
{
    public class Lanche
    {
            public int Id { get; set; }

            [Required]
            [MaxLength(80)]
            public string nome { get; set; } = string.Empty;         
            public string descricao { get; set; } = string.Empty;
            public decimal preco { get; set; }  
            public bool disponivel { get; set; } = true;

            [Required]
            public string categoria { get; set; } = string.Empty;

            public ICollection<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido>();

    }
}

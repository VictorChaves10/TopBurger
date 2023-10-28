using System.ComponentModel.DataAnnotations;

namespace TopBurgers.Models
{
    public class CarrinhoCompraItem
    {

        public int CarrinhoCompraItemID { get; set; }
        public Lanche Lanche { get; set; }
        public int Quantidade { get; set; }

        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }
    }
}

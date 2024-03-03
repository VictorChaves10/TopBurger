using System.Collections;
using System.Collections.Generic;
using TopBurgers.Models;

namespace TopBurgers.ViewModels
{
    public class PedidoLancheViewModel
    {
        public Pedido Pedido { get; set; }
        public IEnumerable<PedidoDetalhe> PedidoDetalhes { get; set;}

    }


}

using TopBurgers.Models;

namespace TopBurgers.Repositories.Interfaces
{
    public interface IPedidoRepository 
    {
        void CriarPedido(Pedido pedido);
    }
}

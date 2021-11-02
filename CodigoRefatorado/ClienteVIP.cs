using CodigoRefatorado.Interfaces;

namespace CodigoRefatorado
{
    public class ClienteVIP : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return (preco - (Constantes.DESCONTO_CLIENTE_VIP * preco));
        }
    }
}

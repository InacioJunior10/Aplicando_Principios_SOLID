using CodigoRefatorado.Interfaces;

namespace CodigoRefatorado
{
    public class ClienteComum : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco);
        }
    }
}

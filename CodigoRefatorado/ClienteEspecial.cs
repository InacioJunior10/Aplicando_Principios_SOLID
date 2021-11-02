using CodigoRefatorado.Interfaces;

namespace CodigoRefatorado
{
    public class ClienteEspecial : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return (preco - (Constantes.DESCONTO_CLIENTE_ESPECIAL * preco));
        }
    }
}

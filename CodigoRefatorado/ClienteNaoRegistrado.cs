using CodigoRefatorado.Interfaces;

namespace CodigoRefatorado
{
    public class ClienteNaoRegistrado : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco;
        }
    }
}

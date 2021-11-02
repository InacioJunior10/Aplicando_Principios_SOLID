using CodigoRefatorado.Enum;
using CodigoRefatorado.Interfaces;

namespace CodigoRefatorado.Service
{
    public class GerenciadorDeDescontosService
    {
        private readonly ICalculaDescontoFidelidade descontoFidelidade;
        private readonly ICalculaDescontoStatusContaFactory descontoStatusConta;

        public GerenciadorDeDescontosService(
                ICalculaDescontoFidelidade _descontoFidelidade,
                ICalculaDescontoStatusContaFactory _descontoStatusConta
            )
        {
            descontoStatusConta = _descontoStatusConta;
            descontoFidelidade = _descontoFidelidade;
        }

        public decimal AplicarDesconto(
                decimal preco,
                StatusContaCliente statusContaCliente,
                int tempoDeContaEmAnos
            )
        {
            decimal precoDepoisDoDesconto = 0;

            precoDepoisDoDesconto = descontoStatusConta
                .GetCalculoDescontoStatusConta(statusContaCliente)
                .AplicarDescontoStatusConta(preco);

            precoDepoisDoDesconto = descontoFidelidade
                .AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);

            return precoDepoisDoDesconto;
        }
    }
}

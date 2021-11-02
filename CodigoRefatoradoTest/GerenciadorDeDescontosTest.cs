using CodigoRefatorado.Enum;
using CodigoRefatorado.Factory;
using CodigoRefatorado.Interfaces;
using CodigoRefatorado.Service;
using Xunit;

namespace CodigoRefatoradoTest
{
    public class GerenciadorDeDescontosTest
    {
        ICalculaDescontoFidelidade calculaDescontoFidelidade;
        ICalculaDescontoStatusContaFactory calculaDescontoStatusContaFactory;

        public GerenciadorDeDescontosTest()
        {
            calculaDescontoFidelidade = new CalculaDescontoFidelidadeService();
            calculaDescontoStatusContaFactory = new CalculaDescontoStatusContaFactory();
        }

        [Theory(DisplayName = "Gerar Desconto Para Cliente Comum")]
        [InlineData(1000, 10, 855)]
        [InlineData(1000, 4, 864)]
        public void GerarDescontoParaClienteComum(decimal preco, int tempoConta, decimal expectedResult)
        {
            var gerenciadorDeDescontos = new GerenciadorDeDescontosService(
                    calculaDescontoFidelidade, calculaDescontoStatusContaFactory
                );

            decimal result = gerenciadorDeDescontos.AplicarDesconto(
                    preco,
                    StatusContaCliente.ClienteComum,
                    tempoConta
                );

            Assert.Equal(expectedResult, result);
        }
        
        [Theory(DisplayName = "Gerar Desconto Para Cliente Especial")]
        [InlineData(1000, 10, 665)]
        [InlineData(1000, 4, 672)]
        public void GerarDescontoParaClienteEspecial(decimal preco, int tempoConta, decimal expectedResult)
        {            
            var gerenciadorDeDescontos = new GerenciadorDeDescontosService(
                    calculaDescontoFidelidade, calculaDescontoStatusContaFactory
                );

            decimal result = gerenciadorDeDescontos.AplicarDesconto(
                    preco,
                    StatusContaCliente.ClienteEspecial,
                    tempoConta
                );

            Assert.Equal(expectedResult, result);
        }
        
        [Theory(DisplayName = "Gerar Desconto Para Cliente VIP")]
        [InlineData(1000, 10, 475)]
        [InlineData(1000, 4, 480)]
        public void GerarDescontoParaClienteVIP(decimal preco, int tempoConta, decimal expectedResult)
        {
            var gerenciadorDeDescontos = new GerenciadorDeDescontosService(
                    calculaDescontoFidelidade, calculaDescontoStatusContaFactory
                );

            decimal result = gerenciadorDeDescontos.AplicarDesconto(
                    preco,
                    StatusContaCliente.ClienteVIP,
                    tempoConta
                );

            Assert.Equal(expectedResult, result);
        }
    }
}

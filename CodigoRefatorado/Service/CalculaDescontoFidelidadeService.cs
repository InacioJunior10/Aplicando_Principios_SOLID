using CodigoRefatorado.Interfaces;

namespace CodigoRefatorado.Service
{
    public class CalculaDescontoFidelidadeService : ICalculaDescontoFidelidade
    {
        public decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos)
        {
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ?
                   (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 :
                   (decimal)tempoDeContaEmAnos / 100;

            return preco - (descontoPorFidelidade * preco);
        }
    }
}

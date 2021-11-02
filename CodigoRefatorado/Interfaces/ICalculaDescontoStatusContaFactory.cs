using CodigoRefatorado.Enum;

namespace CodigoRefatorado.Interfaces
{
    public interface ICalculaDescontoStatusContaFactory
    {
        ICalculaDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente);
    }
}

namespace Intermediario.Services
{
    internal interface IServiçodePagamentoOnline
    {
        double TaxaDePagamento (double valor);
        double Juros (double valor, int meses);
    }
}
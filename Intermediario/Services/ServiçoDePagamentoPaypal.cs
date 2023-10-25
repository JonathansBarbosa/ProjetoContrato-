namespace Intermediario.Services
{
    internal class ServiçoDePagamentoPaypal : IServiçodePagamentoOnline
    {

        private const double TaxaPorcentagem = 0.02;
        private const double JurosMensal = 0.01;
        public double Juros(double valor, int meses)
        {
            return valor * JurosMensal * meses;
        }

        public double TaxaDePagamento(double valor)
        {
            return valor * TaxaPorcentagem; 
        }
    }
}

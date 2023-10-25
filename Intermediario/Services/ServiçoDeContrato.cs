using System;
using Intermediario.Entities;

namespace Intermediario.Services
{
    internal class ServiçoDeContrato
    {
        private IServiçodePagamentoOnline _serviçodePagamentoOnline;

        public ServiçoDeContrato(IServiçodePagamentoOnline serviçodePagamentoOnline)
        {
            _serviçodePagamentoOnline = serviçodePagamentoOnline;
        }
        public void ProcessoDeContrato(Contrato contrato, int meses)
        {
            double cotaBasica = contrato.ValorTotal / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime date = contrato.Data.AddMonths(i);
                double cotaAtualizada = cotaBasica + _serviçodePagamentoOnline.Juros(cotaBasica, i);
                double cotacompleta = cotaAtualizada + _serviçodePagamentoOnline.TaxaDePagamento(cotaAtualizada);
                contrato.AddParcelas(new Parcela(date, cotacompleta));
            }
        }
    }
}
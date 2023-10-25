using System;
using System.Globalization;

namespace Intermediario.Entities
{
    internal class Parcela
    {
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }

        public Parcela(DateTime dataVencimento, double valor)
        {
            DataVencimento = dataVencimento;
            Valor = valor;
        }
        public override string ToString()
        {
            return DataVencimento.ToString("dd/MM/yyyy")
                + " - "
                + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Intermediario.Entities
{
    internal class Contrato 
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Parcela> Parcelas { get; set; }

        public Contrato(int numero, DateTime data, double valortotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valortotal;
            Parcelas = new List<Parcela>();
        }
        public void AddParcelas(Parcela parcelas)
        {
            Parcelas.Add(parcelas);
        }
    }
}

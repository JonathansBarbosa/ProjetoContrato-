using System;
using System.Globalization;
using Intermediario.Entities;
using Intermediario.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira os dados do contrato");
            Console.Write("Número: ");
            int contratoNumero = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime contratoData = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valordoContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o número de parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(contratoNumero, contratoData, valordoContrato); //Instancia os Contratos

            ServiçoDeContrato serviçoDeContrato = new ServiçoDeContrato(new ServiçoDePagamentoPaypal()); //cria um objeto da classe ServiçoDeContrato. Esse objeto é usado para processar contratos.
            serviçoDeContrato.ProcessoDeContrato(contrato, meses); // chama o método ProcessoDeContrato() da classe ServiçoDeContrato. Esse método calcula o valor de cada parcela de um contrato e adiciona à lista de parcelas do contrato.

            Console.WriteLine("Parcelas:");
            foreach (Parcela parcelas in contrato.Parcelas) //Percorre a Lista de Contratos
            {
                Console.WriteLine(parcelas); //Imprime as parcelas pro usuario
            }
            Console.ReadLine();
        }
    }
}
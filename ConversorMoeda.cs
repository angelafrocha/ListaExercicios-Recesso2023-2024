using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComPOO
{
    internal class ConversorMoeda
    {
        public static void ConverterMoeda()
        {
            Console.WriteLine("Digite o valor em reais:");
            double valorReais = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cotação do dólar:");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            double valorDolares = valorReais / cotacaoDolar;

            Console.WriteLine($"O valor em dólares é {valorDolares:0.2f}.");
        }
    }
}

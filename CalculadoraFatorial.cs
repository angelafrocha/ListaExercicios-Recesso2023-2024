using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComPOO
{
    internal class CalculadoraFatorial
    {
        public static void CalcularFatorial()
        {
            int numero;

            while (true)
            {
                Console.WriteLine("Digite um número:");

                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                }
            }

            int fatorial = 1;
            for (int i = 2; i <= numero; i++)
            {
                fatorial *= i;
            }


            Console.WriteLine($"O fatorial de {numero} é {fatorial}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComPOO
{
    internal class NumeroPrimo
    {
        public static void VerificarSeEhPrimo()
        {
            Console.WriteLine("Digite um número para verificar se é primo ou não:");
            int numero = int.Parse(Console.ReadLine());

            bool ehPrimo = true;
            for (int i = 2; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }

            if (ehPrimo)
            {
                Console.WriteLine($"O número {numero} é primo.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não é primo.");
            }
        }
    }
}

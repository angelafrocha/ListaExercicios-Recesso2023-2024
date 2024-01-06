using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComPOO
{
    internal class VerificadorPalindromo
    {
        public static void VerificarPalavra()
        {
            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();

            bool ehPalindromo = VerificaPalindromo(palavra);

            if (ehPalindromo)
            {
                Console.WriteLine($"A palavra {palavra} é um palíndromo.");
            }
            else
            {
                Console.WriteLine($"A palavra{palavra} não é um palíndromo.");
            }
        }
        public static bool VerificaPalindromo(string palavra)
        {
            palavra = palavra.ToLower();

            string palavraInvertida = "";

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                palavraInvertida += palavra[i];
            }
            return palavra == palavraInvertida;
        }
    }
}

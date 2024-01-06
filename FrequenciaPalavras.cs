using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComPOO
{
    internal class FrequenciaPalavras
    {
        public static void ContarPalavas()
        {
            string texto = "";
            Dictionary<string, int> frequencia = new Dictionary<string, int>();

            Console.WriteLine("Digite um texto:");
            texto = Console.ReadLine();

            for (int i = 0; i < texto.Length; i++)
            {
                string palavra = "";
                while (i < texto.Length && texto[i] != ' ')
                {
                    palavra += texto[i];
                    i++;
                }

                if (!frequencia.ContainsKey(palavra))
                {
                    frequencia.Add(palavra, 1);
                }
                else
                {
                    frequencia[palavra]++;
                }
            }

            foreach (KeyValuePair<string, int> par in frequencia)
            {
                Console.WriteLine("{0}: {1}", par.Key, par.Value);
            }
        }
    }
}

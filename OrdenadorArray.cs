using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComPOO
{
    internal class OrdenadorArray
    {
        public static string OrdenarArray()
        {
            Console.WriteLine("Digite o tamanho do array:");
            int tamanho = int.Parse(Console.ReadLine());

            int[] array = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite o valor da posição {0}:", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return $"Array ordenado: {string.Join(" ", array)}";
        }

    }
}

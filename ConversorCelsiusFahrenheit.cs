using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComPOO
{
    internal class ConversorCelsiusFahrenheit
    {
        public static void ConversaoTemperatura()
        {
            Console.WriteLine("Escolha o tipo de conversão");
            Console.WriteLine("1. Celsius para Fahrenheit");
            Console.WriteLine("2. Fahrenheit para Celsius");

            int opcao;
            if (!int.TryParse(Console.ReadLine(), out opcao) || (opcao != 1 && opcao != 2))
            {
                Console.WriteLine("Opção inválida!");
                return;
            }

            Console.Write("Digite a temperatura a ser convertida: ");
            if (!float.TryParse(Console.ReadLine(), out float temperatura))
            {
                Console.WriteLine("Entrada inválida para a temperatura. Saindo...");
                return;
            }

            float resultado = RealizarConversao(opcao, temperatura);

            string unidadeEntrada = (opcao == 1) ? "Celsius" : "Fahrenheit";
            string unidadeSaida = (opcao == 1) ? "Fahrenheit" : "Celsius";

            Console.WriteLine($"{temperatura} graus {unidadeEntrada} = {resultado} graus {unidadeSaida}");

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal ou 'S' para sair.");
            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.S)
            {
                Environment.Exit(0);
            }
            Console.Clear();
        }
        private static float RealizarConversao(int opcao, float temperatura)
        {
            switch (opcao)
            {
                case 1:
                    return (temperatura * 9 / 5) + 32;
                case 2:
                    return (temperatura - 32) * 5 / 9;
                default:
                    throw new ArgumentOutOfRangeException(nameof(opcao), "Opção inválida!");
            }
        }

    }
}

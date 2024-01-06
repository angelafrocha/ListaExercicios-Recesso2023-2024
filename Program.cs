using System.ComponentModel;

namespace LogicaComPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                ExibirMenuPrincipal();

                int opcao;
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 11)
                {
                    Console.Write("Digite o número correspondente às opções.\n");
                }

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        ConversorCelsiusFahrenheit.ConversaoTemperatura();
                        
                        break;
                    case 2:
                        Console.Clear();
                        NumeroPrimo.VerificarSeEhPrimo();

                        break;

                    case 3:
                        Console.Clear();
                        CalculadoraFatorial.CalcularFatorial();

                        break;
                    case 4:
                        Console.Clear();
                        string resultado = OrdenadorArray.OrdenarArray();
                        Console.WriteLine(resultado);

                        break;  

                    case 5:
                        Console.Clear();
                        VerificadorPalindromo.VerificarPalavra();

                        break;
                    case 6:
                        Console.Clear();

                        Console.WriteLine("Digite um número:");
                        double numero = double.Parse(Console.ReadLine());

                        double raizQuadrada = CalculadoraRaiz2.RaizQuadrada(numero);

                        Console.WriteLine($"A raiz quadrada de {numero} é {raizQuadrada}.");

                        break;
                    case 7:
                        Console.Clear();
                        ConversorMoeda.ConverterMoeda();

                        break;
                    case 8:
                        Console.Clear();
                        string senha = "";
                        bool ehValida = false;
                        Console.WriteLine("Digite uma senha:");
                        senha = Console.ReadLine();

                        ehValida = ValidacaoSenha.ValidaSenha(senha);

                        if (ehValida)
                        {
                            Console.WriteLine("A senha é válida.");
                        }
                        else
                        {
                            Console.WriteLine("A senha deve ter ter no mínimo 8 caracteres, conter pelo menos uma letra maiúscula, uma letra minúscula e um número.");
                        }

                        break;

                    case 9:
                        Console.Clear();
                        string cpf = "";
                        bool ehValido = false;

                        Console.WriteLine("Digite um CPF(Apenas números):");
                        cpf = Console.ReadLine();

                        ehValido = ValidacaoCPF.ValidarCPF(cpf);

                        if (ehValido)
                        {
                            Console.WriteLine("O CPF é válido.");
                        }
                        else
                        {
                            Console.WriteLine("O CPF não é válido.");
                        }
                        break;

                    case 10:
                        Console.Clear();
                        FrequenciaPalavras.ContarPalavas();
                        break;
                    case 11:
                        
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }

        static void ExibirMenuPrincipal()
        {
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("***Lista de Exercícios de Recesso***\n");
            Console.ResetColor();
            Console.WriteLine("Digite a opcao desejada");
            Console.WriteLine("1. Converter Celsius-Fahrenheit");
            Console.WriteLine("2. Verificar se um número é primo");
            Console.WriteLine("3. Calcular fatotial");
            Console.WriteLine("4. Ordenar array");
            Console.WriteLine("5. Verificar se uma palavra é palíndromo");
            Console.WriteLine("6. Calcular raiz quadrada");
            Console.WriteLine("7. Converter Dólar para Real");
            Console.WriteLine("8. Validação de senha");
            Console.WriteLine("9. Validação de CPF");
            Console.WriteLine("10. Contar palavras");
            Console.WriteLine("11. Sair");
        }
    }
}
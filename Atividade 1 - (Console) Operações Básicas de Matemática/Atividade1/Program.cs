using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Program
    {
        static void Operacoes(double a, double b)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Você escolheu os números {0} e {1}", a, b);
                Console.WriteLine("\n1. Soma");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Reiniciar");
                Console.WriteLine("6. Sair");
                Console.Write("\nDigite a opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Resultado: " + (a + b));
                        break;
                    case 2:
                        Console.WriteLine("Resultado: " + (a - b));
                        break;
                    case 3:
                        Console.WriteLine("Resultado: " + (a * b));
                        break;
                    case 4:
                        Console.WriteLine("Resultado: " + (a / b));
                        break;
                    case 5:
                        Main(null);
                        return;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (opcao != 6);
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Operações Básicas de Matemática");
            Console.Write("\nDigite o primeiro número: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Operacoes(a, b);
        }
    }
}
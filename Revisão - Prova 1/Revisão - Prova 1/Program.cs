using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão___Prova_1
{
    internal class Program
    {
        static void retangulo()
        {
            Console.Clear();
            Console.Write("Digite a base: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite altura: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nÁrea = " + (a * b));
            Console.Write("\nPerímetro = " + ((a * 2) + (b * 2)));
        }

        static void temperatura()
        {
            Console.Clear();
            Console.Write("Digite a temperatura em graus Celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nTemperatura em Fahrenheit= " + ((9.0 / 5.0) * c + 32));
        }

        static void mercado()
        {
            Console.Clear();

            Console.Write("Digite a quantidade de quilos de café: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o custo por quilo de café: ");
            double q = Convert.ToDouble(Console.ReadLine());
            double totalCafe = n * q;

            Console.Write("\nDigite a quantidade de litros de leite: ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o custo por litro de leite: ");
            double p = Convert.ToDouble(Console.ReadLine());
            double totalLeite = l * p;

            Console.Write("\nDigite a quantidade de quilos de banana: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o custo por quilo de banana: ");
            double t = Convert.ToDouble(Console.ReadLine());
            double totalBanana = b * t;

            Console.WriteLine("\nResumo da Compra:");
            Console.WriteLine($"Café - Total: R$ {totalCafe:F2}");
            Console.WriteLine($"Leite - Total: R$ {totalLeite:F2}");
            Console.WriteLine($"Banana - Total: R$ {totalBanana:F2}");

            double totalGeral = totalCafe + totalLeite + totalBanana;
            Console.WriteLine($"\nTotal gasto no mercado: R$ {totalGeral:F2}");
        }

        static void pesoideal()
        {
            Console.Clear();

            Console.Write("Digite sua altura em metros: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite seu sexo (M ou F): ");
            char sexo = Convert.ToChar(Console.ReadLine());

            if (sexo == 'M' || sexo == 'm')
            {
                Console.Write("\nPeso ideal: " + (72.7 * h - 58) + " KG");
            }
            else if (sexo == 'F' || sexo == 'f')
            {
                Console.Write("\nPeso ideal: " + (62.1 * h - 44.7) + " KG");
            }
            else
            {
                Console.WriteLine("\nVocê não digitou um sexo válido. Pressione qualquer tecla para continuar.");
                Console.ReadKey();
                pesoideal();
            }

        }

        static void calculo()
        {
            Console.Clear();
            Console.Write("Digite um número inteiro positivo: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double a = 0;

            for (int i = 0; i < n; i++)
            {
                a += (n - i) / (i + 1);
            }

            Console.WriteLine(a);
        }

        static void pi()
        {
            Console.Clear();
            decimal pi = 0, s = 0;

            for (int i = 0; i < 15; i++)
            {
                s = s * -1;

                s += (decimal)(1 / Math.Pow((i * 2 + 1), 3));
            }

            pi = (decimal)Math.Pow((double)(32 * s), 1.0 / 3);

            Console.WriteLine("Valor de pi: " + pi);
        }

        static void milho()
        {
            Console.Clear();
            ulong totalGraos = 0;

            for (int i = 0; i < 64; i++)
            {
                totalGraos += (ulong)Math.Pow(2, i);
            }

            Console.WriteLine("Total de grãos de milho no tabuleiro: " + totalGraos);
        }

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Atividades de Revisão - Prova 1");
                Console.WriteLine("\n1. Área e perímetro de retangulo");
                Console.WriteLine("2. Celsius para Fahrenheit");
                Console.WriteLine("3. Compras no mercado");
                Console.WriteLine("4. Peso ideal");
                Console.WriteLine("5. Calculo de A");
                Console.WriteLine("6. Calculo do Pi");
                Console.WriteLine("7. Milho no Xadrez");
                Console.WriteLine("0. Sair");
                Console.Write("\nDigite a opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        retangulo();
                        break;
                    case 2:
                        temperatura();
                        break;
                    case 3:
                        mercado();
                        break;
                    case 4:
                        pesoideal();
                        break;
                    case 5:
                        calculo();
                        break;
                    case 6:
                        pi();
                        break;
                    case 7:
                        milho();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (opcao != 0);
        }
    }
}

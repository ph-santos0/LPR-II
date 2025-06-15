// Pedro Henrique Santos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_1
{
    internal class Program
    {
        static void q1()
        {
            Console.Clear();
            Console.WriteLine("Questão 1");
            Console.Write("Insira o valor de N para progressão aritmética: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int soma = (1 + n) * n / 2;
            Console.WriteLine(soma);

        }

        static void q2()
        {
            Console.Clear();
            Console.WriteLine("Questão 2");
            Console.Write("Insira a nota do aluno: ");
            double nota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a frequencia do aluno: ");
            int freq = Convert.ToInt32(Console.ReadLine());

            if (nota >= 60.0 && freq >= 75)
            {
                Console.WriteLine("Aprovado");
            }
            else if (nota < 60.0 && freq < 75)
            {
                Console.WriteLine("Reprovado por nota e por falta.");
            }
            else if (nota < 60.0 && freq >= 75)
            {
                Console.WriteLine("Reprovado por nota.");
            }
            else
            {
                Console.WriteLine("Reprovado por falta.");
            }

        }

        static void q3()
        {
            Console.Clear();

            Console.WriteLine("Questão 3");
            Console.Write("Insira o raio da lata de óleo: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira a altura da lata de óleo: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double v = 3.1215169;

            double vol = v * (double)Math.Pow(r, 2) * h;

            Console.WriteLine(vol);
        }

        static void q4()
        {
            Console.Clear();

            Console.WriteLine("Questão 4");
            Console.Write("Digite um numero para verificar se é triangular: ");
            double n = Convert.ToDouble(Console.ReadLine());
            int temp = 1;
            bool triangular = false;

            do
            {
                if (temp * (temp + 1) * (temp + 2) == n)
                {
                    triangular = true;
                    Console.WriteLine("É triangular!");
                }
                if (temp * (temp + 1) * (temp + 2) > n)
                {
                    Console.WriteLine("Não é triangular!");
                    break;
                }
                temp++;
            } while (triangular == false);

        }

        static void q5()
        {
            Console.Clear();
            Console.WriteLine("Questão 5");
            int opcao, cont = 0;
            double total = 0;
            do
            {
                cont++;
                Console.Clear();
                Console.WriteLine("Insira os dados do " + cont + "° pedido no mercado:");
                Console.Write("\nNúmero do pedido: ");
                var numeros = new int[cont];
                numeros[cont - 1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Data do pedido(00/00/00): ");
                var datas = new string[cont];
                datas[cont - 1] = Convert.ToString(Console.ReadLine());
                Console.Write("Valor do Pedido: ");
                var preco = new double[cont];
                preco[cont - 1] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade: ");
                var quant = new int[cont];
                quant[cont - 1] = Convert.ToInt32(Console.ReadLine());
                total += preco[cont - 1] * quant[cont - 1];

                Console.WriteLine($"\nTotal até o momento: R$ {total:F2}");

                Console.WriteLine("\n1. Novo pedido");
                Console.WriteLine("0. Sair");
                Console.Write("\nDigite a opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

            } while (opcao != 0);
        }

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Atividades de Revisão - Prova 1");
                Console.WriteLine("\n1. Questão 1");
                Console.WriteLine("2. Questão 2");
                Console.WriteLine("3. Questão 3");
                Console.WriteLine("4. Questão 4");
                Console.WriteLine("5. Questão 5");
                Console.WriteLine("0. Sair");
                Console.Write("\nDigite a opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        q1();
                        break;
                    case 2:
                        q2();
                        break;
                    case 3:
                        q3();
                        break;
                    case 4:
                        q4();
                        break;
                    case 5:
                        q5();
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

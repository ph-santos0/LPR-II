using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Program
    {
        static void Media(double a, double b, double c)
        {
            Console.WriteLine("Média: " + ((a + b + c) / 3));
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Média de notas");
            Console.Write("\nDigite a primeira nota: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Media(a, b, c);
        }
    }
}
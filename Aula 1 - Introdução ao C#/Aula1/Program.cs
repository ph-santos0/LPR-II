using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a primeira aula de C#");
            Console.Write("\nDigite seu nome: ");
            String nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nOlá {0}, sua idade é {1}", nome, idade);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            string resultado = "";

            while (x > 0)
            {
                if (x > 2)
                {
                    resultado = resultado + "a";
                }

                if (x == 2)
                {
                    resultado = resultado + "b c";
                }

                if (x == 1)
                {
                    resultado = resultado + "d";
                    x = x - 1;
                    continue;
                }

                resultado = resultado + "-";
                x = x - 1;
            }

            Console.WriteLine(resultado);

        }
    }
}

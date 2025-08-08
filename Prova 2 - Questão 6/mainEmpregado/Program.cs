using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainEmpregado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Mensalista e1 = new Mensalista();
            Mensalista e2 = new Mensalista();
            Mensalista e3 = new Mensalista();

            e1.Nome = "Pedro";
            e1.Endereco = "Rua David Bicalho";
            e1.Cargo = "Pleno";
            e1.calSalario();
            Console.WriteLine(e1.Informações());

            e2.Nome = "Fabio";
            e2.Endereco = "Rua da Copasa";
            e2.Cargo = "Sênior";
            e2.calSalario();
            Console.WriteLine(e2.Informações());

            e3.Nome = "João";
            e3.Endereco = "Rua Rubão";
            e3.Cargo = "Junior";
            e3.calSalario();
            Console.WriteLine(e3.Informações());


            Horista e4 = new Horista();
            Horista e5 = new Horista();
            Horista e6 = new Horista();

            e4.Nome = "Carlos";
            e4.Endereco = "Rua Flores 3";
            e4.Horas = 300;
            e4.calSalario();
            Console.WriteLine(e4.Informações());

            e5.Nome = "Matheus";
            e5.Endereco = "Rua Flores 3";
            e5.Horas = 200;
            e5.calSalario();
            Console.WriteLine(e5.Informações());

            e6.Nome = "Caio";
            e6.Endereco = "Rua Flores 4";
            e6.Horas = 230;
            e6.calSalario();
            Console.WriteLine(e6.Informações());
        }
    }
}
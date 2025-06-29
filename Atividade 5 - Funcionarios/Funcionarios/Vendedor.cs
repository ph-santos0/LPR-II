using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios {
    public class Vendedor : Pessoa {
        public Vendedor() { }

        public Vendedor(String nome) : base(nome) { 
        }

        public Vendedor(string nome, int idade) : base(nome, idade) {
        }

        public Vendedor(string nome, int idade, string cpf) : base(nome, idade, cpf) {
        }

        public override String Viajar() {
            return base.Viajar() + "\nRealizando Vendas!";
        }
    }
}

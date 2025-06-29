using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios {
    public class Funcionario : Pessoa {
        public Funcionario() {
        }

        public Funcionario(string nome) : base(nome) {
        }

        public Funcionario(string nome, int idade) : base(nome, idade) {
        }

        public Funcionario(string nome, int idade, string cpf) : base(nome, idade, cpf) {
        }

        public override string Viajar() {
            return base.Viajar() + "\nFuncionário em férias!";
        }
    }
}

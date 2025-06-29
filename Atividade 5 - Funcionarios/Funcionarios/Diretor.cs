using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios {
    public class Diretor : Pessoa {
        public Diretor() {
        }

        public Diretor(string nome) : base(nome) {
        }

        public Diretor(string nome, int idade) : base(nome, idade) {
        }

        public Diretor(string nome, int idade, string cpf) : base(nome, idade, cpf) {
        }

        public override string Viajar() {
            return base.Viajar() + "\nDiretor em parceria!";
        }
    }
}

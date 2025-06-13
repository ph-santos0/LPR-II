using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaPessoa
{
    public class Pessoa
    {
        private int id;
        string nome="";

        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            MessageBox.Show("Construindo pessoa");
            this.nome = nome;
        }

        public int Id { get => id; set => id = value; }

        public string Cadastrar()
        {
            return ("Cadastrando pessoa: "+nome);
        }
    }
}

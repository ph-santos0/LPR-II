using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProduto
{
    internal class Computador : IProduto
    {

        private string nome;
        private bool ePerecivel = false;
        private Fornecedor fornecedor;

        public Fornecedor RecuperarFornecedor()
        {
            return fornecedor;
        }

        public void RegistrarVenda(Cliente cliente)
        {
            MessageBox.Show($"Realizada venda para {cliente.Nome}", "Venda");
        }
        public bool EPerecivel { get => ePerecivel; set => ePerecivel = value; }
        public string Nome { get => nome; set => nome = value; }
        public Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }
    }
}

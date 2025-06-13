using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaPessoa
{
    public class Cliente : Pessoa
    {
        Produtos produtos = new Produtos();
        public Cliente(string nome) : base(nome)
        {
            MessageBox.Show("Construindo clientes: " + nome);
        }
        public string Comprar(int idProduto)
        {
            return ("Comprando o produto " + produtos.getProduto(idProduto));
        }
    }
}

    

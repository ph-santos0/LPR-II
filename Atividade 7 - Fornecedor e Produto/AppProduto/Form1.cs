using System;
using System.Windows.Forms;

namespace AppProduto
{
    public partial class Form1 : Form
    {

        private Cliente cliente = null;
        private Fornecedor fornecedor = null;
        private Computador computador = null;

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (computador != null)
            {
                MessageBox.Show("Esse computador já está cadastrado.", "Venda");
                return;
            }

            string nome = textBox3.Text;
            if (nome.Length <= 0)
            {
                MessageBox.Show("Você precisa inserir o nome do computador.", "Venda");
                return;
            }

            computador = new Computador();
            computador.Nome = nome;

            MessageBox.Show("Computador cadastrado com sucesso.", "Venda");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (cliente != null)
            {
                MessageBox.Show("Esse usuario já está cadastrado.", "Venda");
                return;
            }

            string nome = textBox1.Text;
            if (nome.Length <= 0) {
                MessageBox.Show("Você precisa inserir o nome do usuario.", "Venda");
                return;
            }

            cliente = new Cliente(nome);

            MessageBox.Show("Usuário cadastrado com sucesso.", "Venda");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (fornecedor != null)
            {
                MessageBox.Show("Esse fornecedor já está cadastrado.", "Venda");
                return;
            }

            string nome = textBox2.Text;
            if (nome.Length <= 0)
            {
                MessageBox.Show("Você precisa inserir o nome do fornecedor.", "Venda");
                return;
            }

            fornecedor = new Fornecedor(nome);

            MessageBox.Show("Fornecedor cadastrado com sucesso.", "Venda");

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (fornecedor == null)
            {
                MessageBox.Show("O fornecedor não está cadastrado.", "Venda");
                return;
            }

            if (computador == null)
            {
                MessageBox.Show("O computador não está cadastrado.", "Venda");
                return;
            }

            computador.Fornecedor = fornecedor;

            MessageBox.Show("Fornecedor: " + computador.RecuperarFornecedor().Nome, "Venda");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (fornecedor == null)
            {
                MessageBox.Show("O fornecedor não está cadastrado.", "Venda");
                return;
            }

            if (cliente == null)
            {
                MessageBox.Show("O cliente não está cadastrado.", "Venda");
                return;
            }

            if (computador == null)
            {
                MessageBox.Show("O computador não está cadastrado.", "Venda");
                return;
            }

            computador.Fornecedor = fornecedor;

            computador.RegistrarVenda(cliente);
        }
    }
}

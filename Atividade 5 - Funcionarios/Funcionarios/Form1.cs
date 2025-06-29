using System;
using System.Windows.Forms;

namespace Funcionarios
{
    public partial class Form1 : Form
    {

        public Pessoa pessoa;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (radioButton1.Checked)
                {
                    pessoa = new Pessoa();
                    pessoa.Nome = textBox1.Text;
                    pessoa.Cpf = textBox2.Text;
                    pessoa.Idade = Convert.ToInt32(textBox3.Text);
                    MessageBox.Show(pessoa.Cadastrar(), "Dados cadastrados");
                }
                else if (radioButton2.Checked)
                {
                    pessoa = new Diretor(textBox3.Text, Convert.ToInt32(textBox3.Text), textBox2.Text);
                    MessageBox.Show(pessoa.Cadastrar(), "Dados cadastrados");
                }
                else if (radioButton3.Checked)
                {
                    pessoa = new Vendedor(textBox3.Text, Convert.ToInt32(textBox3.Text), textBox2.Text);
                    MessageBox.Show(pessoa.Cadastrar(), "Dados cadastrados");
                }
                else if (radioButton4.Checked)
                {
                    pessoa = new Funcionario(textBox3.Text, Convert.ToInt32(textBox3.Text), textBox2.Text);
                    MessageBox.Show(pessoa.Cadastrar(), "Dados cadastrados");
                }
                else
                {
                    MessageBox.Show("Marque um cargo", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Insira todos os dados", "Erro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pessoa != null)
            {
                MessageBox.Show(pessoa.Viajar(), "Viagem!");
            }
            else
            {
                MessageBox.Show("Cadastre os dados antes", "Erro");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

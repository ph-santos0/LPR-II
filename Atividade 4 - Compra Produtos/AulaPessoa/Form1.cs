using System;
using System.Windows.Forms;

namespace AulaPessoa
{

    public partial class Form1 : Form
    {
        public Cliente p;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                p = new Cliente(textBox2.Text);
                p.Id = Convert.ToInt32(textBox1.Text);
                MessageBox.Show(p.Cadastrar(), "Cadastro");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Erro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p.Comprar(0));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p.Comprar(1));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p.Comprar(2));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p.Comprar(3));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p.Comprar(5));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p.Comprar(4));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (p != null)
            {
                MessageBox.Show(p.Comprar(Convert.ToInt32(textBox3.Text)));
            }
            else
            {
                MessageBox.Show("Sem cliente cadastrado", "Erro");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

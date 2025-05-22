using System;
using System.Linq;
using System.Windows.Forms;

namespace Lista_2
{
    public partial class Questao2 : Form
    {
        public Questao2()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entrada = textBox1.Text;
            entrada = entrada.ToLower().Replace(" ", "");
            string inversa = new string(entrada.Reverse().ToArray());

            if (entrada != "")
            {
                if (entrada == inversa)
                {
                    MessageBox.Show("É um palíndromo!", "Resultado");
                }
                else
                {
                    MessageBox.Show("Não é um palíndromo.", "Resultado");
                }
            }
            else
            {
                MessageBox.Show("Insira um conjunto de caracteres.", "Erro");
            }
        }

    }
}

using System;
using System.Windows.Forms;

namespace Lista_2
{
    public partial class Questao3 : Form
    {
        public Questao3()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ulong.TryParse(textBox1.Text, out ulong numero) || numero < 2)
            {
                MessageBox.Show("Digite um número inteiro maior ou igual a 2.", "Erro");
                return;
            }

            bool primo = true;
            ulong limite = (ulong)Math.Sqrt(numero);

            if (numero == 2)
            {
                primo = true;
            }
            else if (numero % 2 == 0)
            {
                primo = false;
            }
            else
            {
                for (ulong i = 3; i <= limite; i += 2)
                {
                    if (numero % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }
            }

            if (primo)
            {
                MessageBox.Show(numero + " é um número primo.", "Resultado");
            }
            else
            {
                MessageBox.Show(numero + " não é um número primo.", "Resultado");
            }
        }


    }
}

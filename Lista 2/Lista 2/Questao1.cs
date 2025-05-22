using System;
using System.Numerics;
using System.Windows.Forms;

namespace Lista_2
{
    public partial class Questao1 : Form
    {
        public Questao1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (int.TryParse(textBox1.Text, out int n) && n > 0)
            {
                BigInteger a = 0;
                BigInteger b = 1;

                for (int i = 0; i < n; i++)
                {
                    listBox1.Items.Add(a.ToString());
                    BigInteger temp = a + b;
                    a = b;
                    b = temp;
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número inteiro positivo.", "Erro");
            }

        }
    }
}

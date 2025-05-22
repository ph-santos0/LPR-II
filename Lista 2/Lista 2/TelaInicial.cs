using System;
using System.Windows.Forms;

namespace Lista_2
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Questao1 questao1 = new Questao1();
            questao1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Questao2 questao2 = new Questao2();
            questao2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Questao3 questao3 = new Questao3();
            questao3.Show();
        }
    }
}

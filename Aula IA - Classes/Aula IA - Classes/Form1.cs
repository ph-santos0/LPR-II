using System;
using System.Windows.Forms;

namespace Aula_IA___Classes
{
    public partial class Form1 : Form
    {
        public Fusca fusca;
        public Form1()
        {
            InitializeComponent();
            fusca = new Fusca();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fusca fusca = new Fusca();
            fusca.Aro = Convert.ToInt32(comboBox1.Text);
            fusca.Placa = textBox1.Text;
            fusca.CorLataria = textBox2.Text;
            fusca.CorParachoque = textBox3.Text;
            fusca.TipoVidro = comboBox2.Text;
            MessageBox.Show("Dados cadastrados com sucesso!", "Cadastro");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fusca.imprimir(), "Dados do fusca");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fusca.Acelerar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fusca.Ligar();
            label11.Text = "Ligado";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fusca.Desigar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fusca.frear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fusca.TrocarMarcha();
        }
    }
}

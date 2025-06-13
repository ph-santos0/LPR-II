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
            fusca = new Fusca();
            fusca.Aro = Convert.ToInt32(comboBox1.Text);
            fusca.Placa = Placa.Text;
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
            if (fusca.status == true)
            {
                fusca.Acelerar();
                label12.Text = fusca.velocidade.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fusca.Ligar();
            label11.Text = "Ligado";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fusca.Desigar();
            label11.Text = "Desligado";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fusca.frear();
            if (fusca.velocidade < 0)
            {
                fusca.velocidade = 0;
            }
            label12.Text = fusca.velocidade.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fusca.TrocarMarcha();
            if (fusca.marcha == 0)
            {
                label13.Text = "Ré";
            }
            else
            {


                label13.Text = fusca.marcha.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            //velocidade
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //marcha
        }
    }
}

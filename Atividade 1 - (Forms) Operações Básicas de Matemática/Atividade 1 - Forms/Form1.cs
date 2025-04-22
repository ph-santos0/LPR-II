using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_1___Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void InsiraValorB_Click(object sender, EventArgs e)
        {

        }

        private void ValorA_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValorB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Soma_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(ValorA.Text);
                double b = Convert.ToDouble(ValorB.Text);
                Resultado.Text = "Resultado: " + (a + b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.");
            }
        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(ValorA.Text);
                double b = Convert.ToDouble(ValorB.Text);
                Resultado.Text = "Resultado: " + (a - b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.");
            }
        }

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(ValorA.Text);
                double b = Convert.ToDouble(ValorB.Text);
                Resultado.Text = "Resultado: " + (a * b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.");
            }
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(ValorA.Text);
                double b = Convert.ToDouble(ValorB.Text);

                if (b == 0)
                {
                    MessageBox.Show("Não é possível dividir por zero.");
                    return;
                }

                Resultado.Text = "Resultado: " + (a / b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.");
            }
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }
    }
}

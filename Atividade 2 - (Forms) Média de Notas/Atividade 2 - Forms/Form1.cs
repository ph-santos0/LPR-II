using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_2___Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PrimeiraNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void SegundaNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void TerceiraNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(PrimeiraNota.Text);
            double b = Convert.ToDouble(SegundaNota.Text);
            double c = Convert.ToDouble(TerceiraNota.Text);

            double media = (a + b + c) / 3;
            label1.Text = $"Média: {media:F2}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

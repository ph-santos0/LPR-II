using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1___Forms
{
    public partial class FormAtividade8 : Form
    {
        public FormAtividade8()
        {
            InitializeComponent();
        }

        private void KmInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void KmFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResultadoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double kmInicial = Convert.ToDouble(KmInicial.Text);
            double kmFinal = Convert.ToDouble(KmFinal.Text);

            double kmPercorrido = kmFinal - kmInicial;
            double custo = kmPercorrido * 0.85;

            ResultadoLabel.Text = "KM percorrido: " + kmPercorrido + " | Custo: R$ " + custo;
            ResultadoTextBox.Text = "KM percorrido: " + kmPercorrido + " | Custo: R$ " + custo;
        }
    }
}

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
    public partial class FormAtividade7 : Form
    {
        public FormAtividade7()
        {
            InitializeComponent();
        }

        private void Raio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double raio = Convert.ToDouble(Raio.Text);
            double area = 3.14159 * raio * raio;

            Resultado.Text = "Área da circunferência: " + area;
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }
    }
}

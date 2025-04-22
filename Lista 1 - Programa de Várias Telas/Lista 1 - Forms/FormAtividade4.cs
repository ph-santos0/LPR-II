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
    public partial class FormAtividade4 : Form
    {
        public FormAtividade4()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double baseRetangulo = Convert.ToDouble(Base.Text);
            double alturaRetangulo = Convert.ToDouble(Altura.Text);

            double area = baseRetangulo * alturaRetangulo;

            Resultado.Text = "Área do retângulo: " + area;
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void Altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void Base_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

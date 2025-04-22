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
    public partial class FormAtividade3 : Form
    {
        public FormAtividade3()
        {
            InitializeComponent();
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void Numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(Numero.Text);
            double raiz = Math.Sqrt(numero);

            Resultado.Text = "=  " + raiz;
        }
    }
}

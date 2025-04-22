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
    public partial class FormAtividade2 : Form
    {
        public FormAtividade2()
        {
            InitializeComponent();
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void A_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_TextChanged(object sender, EventArgs e)
        {

        }

        private void C_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(A.Text);
            double b = Convert.ToDouble(B.Text);
            double c = Convert.ToDouble(C.Text);

            double resultado = (a + b) * c;
            MessageBox.Show("Resultado: " + resultado, "Resultado");
        }
    }
}

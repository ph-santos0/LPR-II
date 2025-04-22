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
    public partial class FormAtividade5 : Form
    {
        public FormAtividade5()
        {
            InitializeComponent();
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

            double delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                Resultado.Text = "Não existem raízes reais.";
            }
            else
            {
                double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

                if (delta == 0)
                {
                    Resultado.Text = "Raiz única: x = " + raiz1;
                }
                else
                {
                    Resultado.Text = "Raízes: x1 = " + raiz1 + "  / x2 = " + raiz2;
                }
            }
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }
    }
}

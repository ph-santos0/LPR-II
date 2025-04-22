using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1___Forms
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void Atividade1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoje é quarta-feira, 01 de março de 2023", "Atividade 1");
        }

        private void Atividade2_Click(object sender, EventArgs e)
        {
            FormAtividade2 atividade2 = new FormAtividade2();
            atividade2.Show();
        }

        private void Atividade3_Click(object sender, EventArgs e)
        {
            FormAtividade3 atividade3 = new FormAtividade3();
            atividade3.Show();
        }

        private void Atividade4_Click(object sender, EventArgs e)
        {
            FormAtividade4 atividade4 = new FormAtividade4();
            atividade4.Show();
        }

        private void Atividade5_Click(object sender, EventArgs e)
        {
            FormAtividade5 atividade5 = new FormAtividade5();
            atividade5.Show();
        }

        private void Atividade6_Click(object sender, EventArgs e)
        {
            FormAtividade6 atividade6 = new FormAtividade6();
            atividade6.Show();
        }

        private void Atividade7_Click(object sender, EventArgs e)
        {
            FormAtividade7 atividade7 = new FormAtividade7();
            atividade7.Show();
        }

        private void Atividade8_Click(object sender, EventArgs e)
        {
            FormAtividade8 atividade8 = new FormAtividade8();
            atividade8.Show();
        }
    }
}

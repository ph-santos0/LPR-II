using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_11___Livraria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDLivrariaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDLivrariaDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.bDLivrariaDataSet.Table);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Titulo")
            {
                this.tableTableAdapter.FillByTitulo(this.bDLivrariaDataSet.Table, textBox1.Text + "%");
            }
            else if(comboBox1.Text == "Autor")
            {
                this.tableTableAdapter.FillByAutor(this.bDLivrariaDataSet.Table, textBox1.Text + "%");
            }
            else if (comboBox1.Text == "Editora")
            {
                this.tableTableAdapter.FillByEditora(this.bDLivrariaDataSet.Table, textBox1.Text + "%");
            }
            else if (comboBox1.Text == "Ano")
            {
                this.tableTableAdapter.FillByAno(this.bDLivrariaDataSet.Table, textBox1.Text + "%");
            }
        }
    }
}

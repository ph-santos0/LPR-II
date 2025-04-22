namespace Aula2
{
    public partial class Aula2 : Form
    {
        public Aula2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            if (x == 24)
            {
                MessageBox.Show("O valor é 24", "Verificação");
            }
            else
            {
                MessageBox.Show("O não foi 24", "Verificação");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 15;
            while (x > 5)
            {
                x -= 3;
            }
            MessageBox.Show("x = " + x, "Valor de x");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i += 2)
            {
                MessageBox.Show("Vou aparecer 4 vezes");
            }
        }
    }
}

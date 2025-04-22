namespace Aula3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome = "José";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("Nome é " + nome + "\nX é " + x + "\nD é " + d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("X é igual a 10");
            }
            else
            {
                MessageBox.Show(" X é diferente de 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int x = 6;
            while (x > 3)
            {
                resultado = resultado + x;
                x = x - 1;
            }
            for (int z = 1; z < 3; z = z + 1)
            {
                resultado = resultado + z;
            }
            MessageBox.Show("O resultado é: " + resultado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int contador = 0;
            while (contador < 10)
            {
                contador = contador + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                contador = contador - 1;
            }
            MessageBox.Show("O Resultado é: " +
           contador);
        }

    }
}


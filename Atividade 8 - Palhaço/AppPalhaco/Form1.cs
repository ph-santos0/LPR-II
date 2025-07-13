namespace AppPalhaco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private bool verificaCampos()
        {
            if (textBox1.Text == "" ||
                textBox2.Text == "" ||
                textBox3.Text == "" ||
                textBox4.Text == "" ||
                textBox5.Text == "" ||
                textBox6.Text == "" ||
                textBox7.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Erro");
                return false;
            }

            if (!double.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("O campo Altura deve conter um número válido.", "Erro");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                Palhaco palhaco1 = new Palhaco();
                palhaco1.Nome = textBox1.Text;
                palhaco1.Altura = Convert.ToDouble(textBox2.Text);
                palhaco1.Endereco = textBox3.Text;
                palhaco1.Telefone = textBox4.Text;
                palhaco1.Email = textBox5.Text;
                palhaco1.Cpf = textBox6.Text;
                palhaco1.Identidade = textBox7.Text;
                palhaco1.FalarSobreVoce();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
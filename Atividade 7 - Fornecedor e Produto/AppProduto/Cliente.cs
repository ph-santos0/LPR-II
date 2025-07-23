namespace AppProduto
{
    public class Cliente
    {
        private string nome;

        public Cliente()
        {
        }

        public Cliente(string nome)
        {
            this.nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }
    }
}
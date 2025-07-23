namespace AppProduto
{
    public class Fornecedor
    {

        private string nome;

        public Fornecedor()
        {
        }

        public Fornecedor(string nome)
        {
            this.nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }

    }
}
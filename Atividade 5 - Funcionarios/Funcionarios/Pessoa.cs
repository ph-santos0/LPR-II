using System;

namespace Funcionarios
{
    public class Pessoa
    {
        // atributos
        private String nome;
        private int idade;
        private String cpf;

        // construtor
        public Pessoa()
        {
            nome = "";
            idade = 0;
            cpf = "";
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
            idade = 0;
            cpf = "";
        }

        public Pessoa(string nome, int idade) : this(nome)
        {
            this.idade = idade;
            cpf = "";
        }

        public Pessoa(string nome, int idade, string cpf) : this(nome, idade)
        {
            this.cpf = cpf;
        }

        // propriedades
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        // métodos da classe
        public String Cadastrar()
        {
            return "Dados cadastrados com sucesso:\n" + "Nome: " + nome + "\n" + "Idade: " + idade + "\n" + "CPF: " + cpf + "\n";
        }

        public virtual String Viajar()
        {
            return "Pessoa viajando!";
        }

    }
}

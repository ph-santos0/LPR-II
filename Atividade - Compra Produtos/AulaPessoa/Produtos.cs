using System;

namespace AulaPessoa
{
    public class Produtos
    {
        private string[] p = {"Arroz","Feijão","Açucar","Leite","Sal","Macarrão"};
        public string getProduto(int idProduto)
        {
            return p[idProduto];
        }
    }
}
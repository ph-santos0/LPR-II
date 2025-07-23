using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProduto
{
    internal interface IProduto
    {
        bool EPerecivel { get; }

        Fornecedor RecuperarFornecedor();

        void RegistrarVenda(Cliente client);
    }
}

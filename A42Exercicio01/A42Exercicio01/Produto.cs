using System;
using System.Collections.Generic;
using System.Text;

namespace A42Exercicio01
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2")
                + ", " + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2");

        }
    }
}

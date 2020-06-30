using System;
using System.Globalization;

namespace A42Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p.Nome + ", $ " + p.Preco.ToString("F2") + ", " + p.Quantidade + " unidades, Total: $ " + p.ValorTotalEmEstoque().ToString("F2"));
            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            //p.Quantidade = p.Quantidade + int.Parse(Console.ReadLine());
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            //p.Quantidade = p.Quantidade - int.Parse(Console.ReadLine());
            int valor = int.Parse(Console.ReadLine());
            p.RemoverProdutos(valor);


            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}

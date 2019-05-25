using System;

namespace A70Vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quantidade de Produtos
            Console.Write("Informe a quantidade de produtos: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[quantidade];
            double soma = 0;

            for (int i = 0; i < quantidade; i++) {

                Console.Write("informe a descrição do produto " + i + ": ");
                string descricao = Console.ReadLine();
                Console.Write("Infome o preço do produto " + i + ": ");
                double preco = double.Parse(Console.ReadLine());

                vetor[i] = new Produto { Nome = descricao, Preco = preco };

                Console.WriteLine("Inserido no vetor o produto: " + vetor[i].Nome + " com valor: " + vetor[i].Preco);

                soma += vetor[i].Preco;

            }

            double media = soma / quantidade;

            Console.WriteLine("Preço médio = " + media );


        }
    }
}

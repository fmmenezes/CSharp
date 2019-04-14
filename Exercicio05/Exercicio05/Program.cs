using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o código da peça A, quantidade e valor (separado por espaços):");
            string[] peca_a = Console.ReadLine().Split(' ');
            Console.WriteLine("Informe o código da peça B, quantidade e valor (separado por espaços):");
            string[] peca_b = Console.ReadLine().Split(' ');

            int quantidade_a = int.Parse(peca_a[1]);
            double valor_a = double.Parse(peca_a[2]);

            int quantidade_b = int.Parse(peca_b[1]);
            double valor_b = double.Parse(peca_b[2]);

            double resultado = (quantidade_a * valor_a + quantidade_b * valor_b);
            Console.WriteLine("VALOR A PAGAR: R$ " + resultado.ToString("F2"));
        }
    }
}

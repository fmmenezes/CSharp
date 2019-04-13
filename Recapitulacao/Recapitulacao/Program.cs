using System;
using System.Globalization;

namespace Recapitulacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int quartos;
            double preco;
            string[] linha;

            Console.WriteLine("Entre com seu nome completo:");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu ultimo nome, idade e atura (mesma linha):");
            linha = Console.ReadLine().Split(' ');

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(linha[0]);
            Console.WriteLine(linha[1]);

            double altura = double.Parse(linha[2]);

            Console.WriteLine(altura.ToString("F2", CultureInfo.InstalledUICulture));
        }
    }
}

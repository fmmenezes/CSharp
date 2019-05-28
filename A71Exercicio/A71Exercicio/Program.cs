using System;

namespace A71Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Aluguel[] vetor = new Aluguel[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                int numero = i + 1;
                Console.WriteLine("Aluguel #" + numero +":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vetor[i] = new Aluguel { Nome = nome, Email = email, Quarto = quarto };
            }

            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine(vetor[i].Quarto + ": " + vetor[i].Nome + ", " + vetor[i].Email);
            }

        }
    }
}

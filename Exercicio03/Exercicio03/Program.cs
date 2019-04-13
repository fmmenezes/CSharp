using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor 1?");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2?");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 3?");
            int valor3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 4?");
            int valor4 = int.Parse(Console.ReadLine());

            int diferenca = (valor1 * valor2 - valor3 * valor4);

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}

using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;

            Console.WriteLine("Informe o primeiro valor");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine(valor1 + valor2);
        }
    }
}

using System;

namespace ExercicioCond02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro:");
            int numero = int.Parse(Console.ReadLine());
            int resto = numero % 2;

            if (resto == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}

using System;

namespace ExercicioCond03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            int B = int.Parse(Console.ReadLine());

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}

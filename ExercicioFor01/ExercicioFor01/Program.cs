using System;

namespace ExercicioFor01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor: ");
            int x = int.Parse(Console.ReadLine());

            for(int a = 1; a <= x; a = a + 2)
            {
                Console.WriteLine(a);
            }
        }
    }
}

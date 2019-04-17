using System;

namespace ExercicioWhile01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Senha: ");
            int senha = 0;
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Digite a Senha: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}

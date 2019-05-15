using System;

namespace ExercicioFixacao60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Havera deposito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            if(resposta == 's' || resposta == 'S')
            {
                Console.WriteLine("Entre com o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
            }
        }
    }
}

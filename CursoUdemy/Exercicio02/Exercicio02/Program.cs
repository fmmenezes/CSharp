using System;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14159;
            double raio;
            double resultado;

            Console.WriteLine("Digite o valor:");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine(raio);

            resultado = PI * raio * raio;

            Console.WriteLine(resultado.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}

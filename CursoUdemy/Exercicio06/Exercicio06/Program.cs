using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor A:");
            double vA = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor B:");
            double vB = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor C:");
            double vC = double.Parse(Console.ReadLine());

            double triangulo = ((vA * vC) / 2);
            double circulo = 3.14159 * vC * vC;
            double trapezio = (vA + vB) / 2 * vC;
            double quadrado = vB * vB;
            double retangulo = vA * vB;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));

        }
    }
}

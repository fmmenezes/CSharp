using System;

namespace ExemploTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Digite o Valores do Triangulo X:");
            x.La = double.Parse(Console.ReadLine());
            x.Lb = double.Parse(Console.ReadLine());
            x.Lc = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valores do Triangulo Y:");

            y.La = double.Parse(Console.ReadLine());
            y.Lb = double.Parse(Console.ReadLine());
            y.Lc = double.Parse(Console.ReadLine());

            double p = (x.La + x.Lb + x.Lc) / 2;
            double areaX = Math.Sqrt(p * (p - x.La) * (p - x.Lb) * (p - x.Lc));

            p = (y.La + y.Lb + y.Lc) / 2;
            double areaY = Math.Sqrt(p * (p - y.La) * (p - y.Lb) * (p - y.Lc));

            Console.WriteLine("Area do triangulo X: " + areaX);
            Console.WriteLine("Area do triangulo Y: " + areaY);
        }
    }
}

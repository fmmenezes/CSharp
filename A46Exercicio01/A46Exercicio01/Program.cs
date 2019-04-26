using System;
using System.Globalization;

namespace A46Exercicio01
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2"), CultureInfo.InvariantCulture);

            double vol = Volume(raio);
            Console.WriteLine("Volume: " + vol.ToString("F2"),CultureInfo.InvariantCulture );
            Console.WriteLine("Valor de PI: " + Pi);
        }

        static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}

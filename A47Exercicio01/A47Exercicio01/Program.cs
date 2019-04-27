using System;
using System.Globalization;

namespace A47Exercicio01
{
    class Program
    {
        //static double Pi = 3.14;

        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double circ = Circunferencia(raio);
            double circ = calc.Circunferencia(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2"), CultureInfo.InvariantCulture);

            //double vol = Volume(raio);
            double vol = calc.Volume(raio);
            Console.WriteLine("Volume: " + vol.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor de PI: " + calc.Pi);

        }


    }
}

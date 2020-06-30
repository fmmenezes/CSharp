using System;

namespace A45Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a largura e altura do retangulo:");
            //double Largura = double.Parse(Console.ReadLine());
            //double Altura = double.Parse(Console.ReadLine());

            Retangulo r = new Retangulo();

            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());


            Console.WriteLine("AREA = " + r.Area().ToString("F2"));
            Console.WriteLine("PERIMETRO = " + r.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2"));
        }

        
    }
}

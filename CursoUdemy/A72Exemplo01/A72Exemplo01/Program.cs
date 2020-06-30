using System;

namespace A72Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Somador.Soma(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                    
            
            Console.WriteLine(x);
        }
    }
}

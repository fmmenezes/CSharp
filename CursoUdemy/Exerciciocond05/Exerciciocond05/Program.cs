using System;

namespace Exerciciocond05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o codigo do produto:");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantdade:");
            int quantidade = int.Parse(Console.ReadLine());

            double preco = 0;

            if (codigo == 1)
            {
                preco = 4.00;
            }
            else if (codigo == 2)
            {
                preco = 4.50;
            }
            else if(codigo == 3)
            {
                preco = 5.00;
            }
            else if(codigo == 4)
            {
                preco = 2.00;
            }
            else if(codigo == 1.50)
            {
                preco = 1.50;
            }
    
            if(preco > 0)
            {
                double total = quantidade * preco;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
            }
               
        }
    }
}

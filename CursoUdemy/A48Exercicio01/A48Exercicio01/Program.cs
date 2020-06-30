using System;

namespace A48Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual e a cotacao do dolar? ");
            double cot = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares voce vai comprar? ");
            double vlr = double.Parse(Console.ReadLine());
            double total = ConversorDeMoeda.DolarParaReal(cot, vlr);
            double totalIOF = ConversorDeMoeda.AdicionaIOF(total);
            Console.WriteLine("Valor a ser pago em reais = " + totalIOF.ToString("F2"));
        }
    }
}

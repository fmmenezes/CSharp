using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codigo do Funcionario: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de Horas Trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor Hora: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("NUMBER: " + codigo);
            double salario = horas * valor;
            Console.WriteLine("SALARY: U$ " + salario.ToString("F2"));
        }
    }
}

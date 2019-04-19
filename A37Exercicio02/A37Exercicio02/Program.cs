using System;

namespace A37Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F1 = new Funcionario();
            Funcionario F2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario");
            Console.Write("Nome: ");
            F1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            F1.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionario");
            Console.Write("Nome: ");
            F2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            F2.Salario = double.Parse(Console.ReadLine());

            double SalarioMedio = (F1.Salario + F2.Salario) / 2;

            Console.WriteLine("Salario Medio = " + SalarioMedio);

        }
    }
}

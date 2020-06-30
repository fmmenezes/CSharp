using System;

namespace A45Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno: ");
            aluno.NotaT1 = double.Parse(Console.ReadLine());
            aluno.NotaT2 = double.Parse(Console.ReadLine());
            aluno.NotaT3 = double.Parse(Console.ReadLine());
            double NotaF = aluno.SomaNota();
            Console.WriteLine("NOTA FINAL = " + NotaF.ToString("F2"));

            if (NotaF >= 60)
            {
                Console.WriteLine("APROVADO ");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.PontosFaltantes().ToString("F2") + " PONTOS");
            }


            

        }
    }
}

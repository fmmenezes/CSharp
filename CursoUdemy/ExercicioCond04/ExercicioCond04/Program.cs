using System;

namespace ExercicioCond04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a Hora Inicial:");
            int horaInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Hora Final");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao;

            if (horaInicial >= horaFinal)
            {
                duracao = 24 - horaInicial + horaFinal;
            }else
            {
                duracao = horaFinal - horaInicial;
            }
          
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }

    }
}

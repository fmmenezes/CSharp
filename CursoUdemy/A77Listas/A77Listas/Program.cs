using System;
using System.Collections.Generic;

namespace A77Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marcos");
            

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Numero de registros: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome que começa com A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo nome que começa com A: " + s2);

            int pos = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posicao do primeiro registro que começa com A: " + pos);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posicao do ultimo registro que começa com A: " + pos2);

            List<string> list2 = new List<string>();
            list2 = list.FindAll(x => x.Length == 5);

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

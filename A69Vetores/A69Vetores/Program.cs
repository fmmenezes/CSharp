﻿using System;

namespace A69Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());

                sum += vect[i];

            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2"));

            
        }
    }
}

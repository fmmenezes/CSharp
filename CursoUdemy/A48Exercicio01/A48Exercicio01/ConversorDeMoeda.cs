using System;
using System.Globalization;

namespace A48Exercicio01
{
    class ConversorDeMoeda
    {
        static double iof = 6.0;

        public static double DolarParaReal(double cotacao, double valor)
        {
            return cotacao * valor;
        }

        public static double AdicionaIOF(double valor)
        {
            return valor + (valor * 6 / 100);
        }
    }
}
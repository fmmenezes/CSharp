using System;

namespace ExemploTriangulo
{
    class Triangulo
    {
        public double La;
        public double Lb;
        public double Lc;

        public double CalculaArea()
        {
            double p = (La + Lb + Lc) / 2;
            double area = Math.Sqrt(p * (p - La) * (p - Lb) * (p - Lc));
            return area;
        } 
    }
}

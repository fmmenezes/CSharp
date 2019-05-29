using System;
using System.Collections.Generic;
using System.Text;

namespace A72Exemplo02
{
    class Somador
    {
        public static double Soma(double[] nums)
        {
            double sum = 0;

            for (int i = 0; i < nums.Length; i++ )
            {
                sum += nums[i];
            }

            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems.Utility
{
    public class FindTheNumber
    {
        public void Find_Number(int num)
        {
            double powerOfTwo = Math.Pow(2, num);
            double min = 0;
            double max = powerOfTwo - 1;
            while (min <= max)
            {
                double mid_value = (min + max) / 2;
                if (mid_value == num)
                {
                    Console.WriteLine("The number is: " + mid_value);
                    break;
                }
                if (num > mid_value)
                {
                    max = mid_value - 1;
                    Console.WriteLine("The number is: " + max);
                    break;
                }
                else
                {
                    min = mid_value + 1;
                    Console.WriteLine("The number is: " + min);
                    break;
                }
            }
        }
    }
}

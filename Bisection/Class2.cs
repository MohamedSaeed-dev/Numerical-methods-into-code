using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection
{
    public class Class2
    {
        public static double f(double x)
        {
            return (x * x * x) - 4 * x - 9;
        }
        public static void bisection2()
        {
            double a = 0;
            double b = 0;
            for (int i = 0; ; i++)
            {
                if (f(i) * f(i+1) < 0)
                {
                    a = i;
                    b = i + 1;
                    break;
                }
            }

            double new_x;
            int iteration = 1;
            while (iteration <= 4)
            {
                new_x = (a + b) / 2;
                double fc = f(new_x);
                if (f(a) * fc < 0)
                {
                    b = new_x;
                }
                else
                {
                    a = new_x;
                }
                Console.WriteLine($"{iteration} , [{a}, {b}] , {new_x} ");
                iteration++;
            }
        }
    }
}

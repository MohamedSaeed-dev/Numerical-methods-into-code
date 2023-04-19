using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection
{
    public class Class3
    {
        public static double f(double x)
        {
            return (x*x*x) - 2*x - 5;
        }
        public static void bisection3()
        {
            double a = 0;
            double b = 0;
            for (int i = 0; ; i++)
            {
                if (f(i) * f(i + 1) < 0)
                {
                    a = i;
                    b = i + 1;
                    break;
                }
            }
            double new_x;
            double old_x = 0;
            double Ea = 0;
            int iteration = 1;
            while (true)
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
                if (iteration > 1)
                {
                    Ea = Math.Abs(new_x - old_x);
                    if ((Ea < (0.5 * Math.Pow(10,-3))))
                    {
                        Console.WriteLine($"{iteration} , [{a}, {b}] , {new_x} , {Ea} ");
                        break;
                    }
                }
                old_x = new_x;
                Console.WriteLine($"{iteration} , [{a}, {b}] , {new_x} , {Ea} ");
                iteration++;
            }
        }
    }
}

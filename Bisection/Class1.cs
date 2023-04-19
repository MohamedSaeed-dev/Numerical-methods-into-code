using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection
{
    public class Class1
    {
        public static double f(double x)
        {
            return x-Math.Exp(-x);
        }
        public static void bisection1()
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
            double old_x = 0;
            double Ep = 0;
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
                    Ep = (Math.Abs((new_x - old_x) / new_x) * 100);
                    if ((Ep / 100) < (0.12))
                    {
                        Console.WriteLine($"{iteration} , [{a}, {b}] , {new_x} , {Ep} ");
                        break;
                    }
                }
                old_x = new_x;
                Console.WriteLine($"{iteration} , [{a}, {b}] , {new_x} , {Ep} ");
                iteration++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection
{
    internal class Class5
    {
       static public double f(double x)
        {
            return (x*x*x) - 2*x - 5;
        }
   
       static public void secant()
        {
            double x_1 = 2;
            double x0 = 3;
            double fx_1 = f(x_1);
            int iteration = 1;
            while (true)
            {
                double fxi = f(x0);
                double x1 = x0 - ((fxi * (x_1-x0))/(fx_1 - fxi));
                double Ea = Math.Abs(x1 - x0);
                if(Ea < 0.5*Math.Pow(10,-3+1))
                {
                    Console.WriteLine($"{iteration}, {x_1}, {fx_1}, {x0}, {fxi}, {x1}, {Ea}");
                    break;
                }
                Console.WriteLine($"{iteration}, {x_1}, {fx_1}, {x0}, {fxi}, {x1}, {Ea}");
                x_1 = x0;
                x0 = x1;
                fx_1 = fxi;
                iteration++;

            }


        }
    }
}

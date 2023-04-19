using System;

namespace Bisection
{
    internal class Class4
    {
        public static double f(double x)
        {
            return Math.Exp(-x) - Math.Sin(x);
        }
        public static double fh(double xa)
        {
            Func<double, double> f = x => Math.Exp(-x) - Math.Sin(x);
            double h = 1e-8;
            Func<double, double> df = x => (f(x + h) - f(x - h)) / (2 * h);
            return df(xa);
        }
        public static void newton()
        {
            double x = 0.6;
            int iteration = 1;
            while (true)
            {
                double fx = f(x);
                double fhx = fh(x);
                double xi = x - (fx / fhx);

                double Ea = Math.Abs(xi - x);

                if (Ea <= 0.5 * Math.Pow(10,-3))
                {
                    Console.WriteLine($"{iteration}, {x}, {fx}, {fhx}, {xi}, {Ea}%");
                    break;
                }
                Console.WriteLine($"{iteration}, {x}, {fx}, {fhx}, {xi}, {Ea}%");
                x = xi;
                iteration++;
            }

        }
    }
}

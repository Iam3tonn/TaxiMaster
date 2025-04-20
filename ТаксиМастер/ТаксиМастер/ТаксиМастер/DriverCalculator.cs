using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТаксиМастер
{
    public static class DriverCalculator
    {
        public static double CalculateViolationCoefficient(int N, int T)
        {
            if (N == 0) return 0.0;
            if (N >= 1 && N <= 3 && T > 20) return 0.5;
            if (N >= 4 || (N >= 1 && T <= 20)) return 1.0;
            if (N >= 10) return 2.0;
            return 0.0;
        }

        public static int CalculateRating(double S, int C, double A, int P)
        {
            if (S < 0 || C < 0 || A < 0 || P < 0) return -1;

            double result = ((0.4 * S + 0.3 * C + 0.2 * A + 0.1 * P) / 10.0) * 5.0;
            return (int)Math.Round(result);
        }
    }
}

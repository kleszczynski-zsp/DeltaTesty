using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaTesty
{
    public class Delta
    {
        public double GetSqrt(int numberToSqrt)
        {
            return GetSqrt((double)numberToSqrt);
        }
        public double GetSqrt(double numberToSqrt)
        {
            return Math.Sqrt(numberToSqrt);
        }
        public double GetDelta(int a, int b, int c)
        {
            return b * b - 4 * a * c;
        }
        public double GetX1(int a, int b, double d)
        {
            return Math.Round((-b + GetSqrt(d)) / (2 * a), 2);
        }
        public double GetX2(int a, int b, double d)
        {
            return Math.Round((-b - GetSqrt(d)) / (2 * a), 2);
        }
        public double GetX0(int a, int b)
        {
            return Math.Round((-b / (double)(2 * a)), 2);
        }
        public bool? CheckDelta(double delta)
        {
            if (delta < 0)
                return null;
            if (delta == 0)
                return false;
            return true;
        }
    }
}

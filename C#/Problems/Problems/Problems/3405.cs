using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3405 : IProblem
    {
        //NOT SOLVED
        public bool Test()
        {
            var n = 5581;
            var m = 58624;
            var k = 4766;

            var expected = 846088010;

            var result= CountGoodArrays(n, m, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountGoodArrays(int n, int m, int k)
        {
            long mod = (long)Math.Pow(10, 9) + 7;
            long result = m * BinomialCoefficientWithModulo(n - 1, k, mod) * PowerWithModulo(m - 1, n - k - 1, m);
            return  (int)(result % mod);
        }

        private long PowerWithModulo(long a, long n, long m)
        {
            long result = 1;
            a %= m;

            while (n > 0)
            {
                if ((n & 1) == 1)
                    result = (result * a) % m;

                a = (a * a) % m;
                n >>= 1;
            }

            return result;
        }

        private long BinomialCoefficientWithModulo(long n, long k, long m)
        {
            if (k < 0 || k > n)
                return 0;
            if (k == 0 || k == n)
                return 1;

            long numerator = 1;
            long denominator = 1;

            for (int i = 0; i < k; i++)
            {
                numerator = (numerator * (n - i)) % m;
                denominator = (denominator * (i + 1)) % m;
            }

            long inverseDenominator = PowerWithModulo(denominator, m - 2, m);
            return (numerator * inverseDenominator) % m;
        }
    }
}

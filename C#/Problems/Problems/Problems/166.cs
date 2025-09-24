using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _166 : IProblem
    {
        public bool Test()
        {
            var numerator = 4;
            var denominator = 333;

            var expected = "0.(012)";

            var result = FractionToDecimal(numerator, denominator);

            Console.WriteLine(result);

            return expected == result;
        }

        public string FractionToDecimal(int numerator, int denominator)
        {
            var sign = numerator <= 0 && denominator < 0 || numerator >= 0 && denominator > 0 ? "" : "-";
            long n = Math.Abs((long)numerator);
            long d = Math.Abs((long)denominator);
            var integer = (n / d).ToString();
            n %= d;
            if (n == 0)
                return $"{sign}{integer}";
            var fracBuilder = new StringBuilder();
            var numerators = new Dictionary<long, int>();
            var repeat = -1;
            for (int i = 0; i < 10000; ++i)
            {
                n *= 10;
                if (numerators.ContainsKey(n))
                {
                    repeat = numerators[n];
                    break;
                }

                numerators[n] = i;
                var digit = n / d;
                fracBuilder.Append((char)('0' + digit));
                n %= d;
                if (n == 0)
                    break;
            }

            var frac = fracBuilder.ToString();
            if (repeat != -1)
                frac = $"{frac.Substring(0, repeat)}({frac.Substring(repeat)})";

            return $"{sign}{integer}.{frac}";
        }
    }
}

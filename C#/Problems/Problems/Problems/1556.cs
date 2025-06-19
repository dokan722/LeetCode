using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1556 : IProblem
    {
        public bool Test()
        {
            var n = 2137;

            var expected = "2.137";

            var result = ThousandSeparator(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public string ThousandSeparator(int n)
        {
            if (n == 0)
                return "0";
            var result = new StringBuilder();

            while (n != 0)
            {
                var mod = n % 1000;
                n -= mod;

                if (n != 0)
                {
                    var modS = mod.ToString();
                    result.Insert(0, string.Concat(".", new string('0', 3 - modS.Length), modS));
                    n /= 1000;
                }
                else
                {
                    result.Insert(0, mod.ToString());
                }
            }



            return result.ToString();
        }
    }
}

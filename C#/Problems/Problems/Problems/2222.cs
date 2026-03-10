using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2222 : IProblem
    {
        public bool Test()
        {
            var s = "001101";

            var expected = 6;

            var result = NumberOfWays(s);

            Console.WriteLine(result);

            return result == expected;
        }


        public long NumberOfWays(string s)
        {
            var n = s.Length;
            var zeros = 0;
            var ones = 0;
            long zeroFirst = 0;
            long oneFirst = 0;
            long result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == '0')
                {
                    result += zeroFirst;
                    oneFirst += ones;
                    zeros++;
                }
                else
                {
                    result += oneFirst;
                    zeroFirst += zeros;
                    ones++;
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3666 : IProblem
    {
        public bool Test()
        {
            var s = "0101";
            var k = 3;

            var expected = 2;

            var result = MinOperations(s, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinOperations(string s, int k)
        {
            var n = s.Length;
            var zeros = 0;
            foreach (var c in s)
                if (c == '0')
                    zeros++;
            if (zeros == 0)
                return 0;
            if (n == k)
                return zeros == n ? 1 : -1;
            var ones = n - zeros;
            var b = n - k;
            int result = int.MaxValue;
            if (k % 2 == zeros % 2)
            {
                result = Math.Max((zeros + k - 1) / k, (ones + b - 1) / b);
                if (result % 2 == 0)
                    result++;
            }
            if (zeros % 2 == 0)
            {
                var even = Math.Max((zeros + k - 1) / k, (zeros + b - 1) / b);
                if (even % 2 == 1)
                    even++;
                result = Math.Min(result, even);
            }

            return result == int.MaxValue ? -1 : result;
        }
    }
}

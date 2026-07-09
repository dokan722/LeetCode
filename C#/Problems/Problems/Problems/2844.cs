using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2844 : IProblem
    {
        public bool Test()
        {
            var num = "2245047";

            var expected = 2;

            var result = MinimumOperations(num);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumOperations(string num)
        {
            var zero = false;
            var five = false;
            var zeros = 0;
            var n = num.Length;
            for (int i = n - 1; i >= 0; --i)
            {
                if (zero && (num[i] == '5' || num[i] == '0'))
                    return n - i - 2;
                if (five && (num[i] == '2' || num[i] == '7'))
                    return n - i - 2;
                if (num[i] == '0')
                {
                    zeros++;
                    zero = true;
                }
                else if (num[i] == '5')
                    five = true;
            }

            return n - zeros;
        }
    }
}

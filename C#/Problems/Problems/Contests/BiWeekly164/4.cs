using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Problems;

namespace Problems.Contests.BiWeekly164
{
    public class _4 : IProblem
    {
        public bool Test()
        {
            var s = "0101";

            var k = 3;

            var expected = 1;

            var result = MinOperations(s, k);

            Console.WriteLine(result);

            return expected == result;
        }


        // UNSOLVED
        public int MinOperations(string s, int k)
        {
            var zeros = 0;
            var ones = 0;
            foreach (var c in s)
            {
                if (c == '0')
                    zeros++;
                else
                    ones++;
            }

            if (zeros == 0)
                return 0;

            var mod = zeros % k;
            if (mod != 0 && k % mod != 0 && k % (k - mod) != 0)
                return -1;

            return zeros / k + (mod == 0 ? 0 : (k % mod != 0 ? k / mod : k / (k - mod)));
        }
    }
}

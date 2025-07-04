using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3307 : IProblem
    {
        public bool Test()
        {
            var k = 3;

            var operations = new int[] {1,0};

            var expected = 'a';

            var result = KthCharacter(k, operations);

            Console.WriteLine(result);

            return result == expected;
        }

        public char KthCharacter(long k, int[] operations)
        {
            int t;
            var swaps = 0;
            while (k != 1)
            {
                t = (int)Math.Log(k, 2);
                if ((1L << t) == k)
                {
                    t--;
                }
                k -= (1L << t);
                swaps += operations[t];
            }
            return (char)('a' + swaps % 26);
        }
    }
}

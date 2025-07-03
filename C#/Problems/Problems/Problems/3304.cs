using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3304 : IProblem
    {
        public bool Test()
        {
            var k = 5;

            var expected = 'b';

            var result = KthCharacter(k);

            Console.WriteLine(result);

            return result == expected;
        }

        public char KthCharacter(int k)
        {
            int result = 0;
            int t;
            while (k != 1)
            {
                t = (int)Math.Log(k, 2);
                if ((1 << t) == k)
                {
                    t--;
                }
                k -= (1 << t);
                result++;
            }
            return (char)('a' + result % 26);
        }
    }
}

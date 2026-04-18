using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3783 : IProblem
    {
        public bool Test()
        {
            var n = 25;

            var expected = 27;

            var result = MirrorDistance(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MirrorDistance(int n)
        {
            var rev = 0;
            var num = n;
            while (num > 0)
            {
                rev *= 10;
                rev += num % 10;
                num /= 10;
            }
            return Math.Abs(rev - n);
        }
    }
}

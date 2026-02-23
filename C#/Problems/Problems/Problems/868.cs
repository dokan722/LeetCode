using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _868 : IProblem
    {
        public bool Test()
        {
            var n = 22;

            var expected = 2;

            var result = BinaryGap(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int BinaryGap(int n)
        {
            if (BitOperations.PopCount((uint)n) < 2)
                return 0;
            while (n % 2 == 0)
                n >>= 1;
            var result = 0;
            var count = 0;
            while (n != 0)
            {
                n >>= 1;
                if (n % 2 == 1)
                {
                    result = Math.Max(result, count + 1);
                    count = 0;
                }
                else
                    count++;
            }

            return result;
        }
    }
}

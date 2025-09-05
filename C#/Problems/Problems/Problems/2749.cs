using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2749 : IProblem
    {
        public bool Test()
        {
            var num1 = 3;
            var num2 = -2;

            var expected = 3;

            var result = MakeTheIntegerZero(num1, num2);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MakeTheIntegerZero(int num1, int num2)
        {
            for (int i = 1;; i++)
            {
                long next = num1 - i * (long)num2;
                if (next < i)
                    return -1;
                var count = BitOperations.PopCount((ulong)next);
                if (count <= i)
                    return i;
            }
        }
    }
}

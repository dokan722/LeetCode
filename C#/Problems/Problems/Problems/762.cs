using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _762 : IProblem
    {
        public bool Test()
        {
            var left = 6;
            var right = 10;


            var expected = 4;

            var result = CountPrimeSetBits(left, right);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountPrimeSetBits(int left, int right)
        {
            var result = 0;
            for (int i = left; i <= right; ++i)
            {
                var bits = BitOperations.PopCount((uint)i);
                if (bits == 2 || bits == 3 || bits == 5 || bits == 7 || bits == 11 || bits == 13 || bits == 17 || bits == 19)
                    result++;
            }

            return result;
        }
    }
}

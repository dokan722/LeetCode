using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2654 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 6, 3, 4 };

            var expected = 4;

            var result = MinOperations(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinOperations(int[] nums)
        {
            var n = nums.Length;
            var ones = 0;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] == 1)
                    ones++;
            }

            if (ones > 0)
                return n - ones;

            var minDist = int.MaxValue;
            for (int i = 0; i < n; ++i)
            {
                var curr = nums[i];
                for (int j = i + 1; j < n; ++j)
                {
                    curr = GCD(curr, nums[j]);
                    if (curr == 1)
                    {
                        minDist = Math.Min(j - i - 1, minDist);
                        break;
                    }
                }
            }

            if (minDist > n)
                return -1;

            return n + minDist;
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}

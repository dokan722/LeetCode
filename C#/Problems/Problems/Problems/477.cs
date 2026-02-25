using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _477 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 4, 14, 2 };

            var expected = 6;

            var result = TotalHammingDistance(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int TotalHammingDistance(int[] nums)
        {
            var zeros = new int[32];
            var ones = new int[32];
            var result = 0;
            foreach (var num in nums)
            {
                var tmp = num;
                for (int i = 0; i < 32; ++i)
                {
                    var rest = tmp % 2;
                    if (rest == 0)
                    {
                        result += ones[i];
                        zeros[i]++;
                    }
                    else
                    {
                        result += zeros[i];
                        ones[i]++;
                    }
                    tmp >>= 1;
                }
            }
            return result;
        }
    }
}

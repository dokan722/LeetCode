using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1679 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4 };
            var k = 5;

            var expected = 2;

            var result = MaxOperations(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxOperations(int[] nums, int k)
        {
            var counts = new Dictionary<int, int>();
            var result = 0;
            foreach (var num in nums)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
                var req = k - num;
                if (req != num)
                {
                    if (counts.ContainsKey(k - num) && counts[k - num] >= counts[num])
                        result++;
                }
                else
                {
                    if (counts[num] % 2 == 0)
                        result++;
                }
            }

            return result;
        }
    }
}

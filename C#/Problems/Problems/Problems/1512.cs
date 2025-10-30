using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1512 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 1, 1, 3 };

            var expected = 4;

            var result = NumIdenticalPairs(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int NumIdenticalPairs(int[] nums)
        {
            var counts = new Dictionary<int, int>();
            var result = 0;
            foreach (var num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    result += counts[num];
                    counts[num]++;
                }
                else
                    counts[num] = 1;
            }

            return result;
        }
    }
}

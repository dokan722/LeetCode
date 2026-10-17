using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2913 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 1 };

            var expected = 15;

            var result = SumCounts(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SumCounts(IList<int> nums)
        {
            var n = nums.Count;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                var present = new bool[101];
                var cur = 0;
                for (int j = i; j < n; ++j)
                {
                    if (!present[nums[j]])
                    {
                        present[nums[j]] = true;
                        cur++;
                    }
                    result += cur * cur;
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _565 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 5, 4, 0, 3, 1, 6, 2 };

            var expected = 4;

            var result = ArrayNesting(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int ArrayNesting(int[] nums)
        {
            var n = nums.Length;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                var l = 1;
                if (nums[i] != -1)
                {
                    var cur = nums[i];
                    nums[i] = -1;
                    while (cur != i)
                    {
                        l++;
                        var val = nums[cur];
                        nums[cur] = -1;
                        cur = val;
                    }
                    result = Math.Max(result, l);
                }
            }

            return result;
        }
    }
}

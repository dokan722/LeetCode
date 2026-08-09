using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2780 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 2, 2 };

            var expected = 2;

            var result = MinimumIndex(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumIndex(IList<int> nums)
        {
            var n = nums.Count;
            var dom = nums[0];
            var domc = 1;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] == dom)
                    domc++;
                else
                {
                    if (domc > 0)
                        domc--;
                    else
                    {
                        dom = nums[i];
                        domc = 1;
                    }
                }
            }
            var c = 0;
            foreach (var num in nums)
                if (num == dom)
                    c++;
            var cur = 0;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] == dom)
                    cur++;

                if (cur > (i + 1) / 2 && c - cur > (n - i - 1) / 2)
                    return i;
            }

            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3719 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 2, 2, 5, 4 };

            var expected = 5;

            var result = LongestBalanced(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LongestBalanced(int[] nums)
        {
            var n = nums.Length;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                var even = new HashSet<int>();
                var odd = new HashSet<int>();
                for (int j = i; j < n; ++j)
                {
                    if (nums[j] % 2 == 0)
                        even.Add(nums[j]);
                    else
                        odd.Add(nums[j]);
                    if (even.Count == odd.Count)
                        result = Math.Max(result, j - i + 1);
                }
            }

            return result;
        }
    }
}

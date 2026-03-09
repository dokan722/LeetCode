using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3804 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { -1, 1, 0 };

            var expected = 5;

            var result = CenteredSubarrays(nums);

            Console.WriteLine(result);

            return result == expected;
        }
        public int CenteredSubarrays(int[] nums)
        {
            var n = nums.Length;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                var sum = 0;
                var present = new HashSet<int>();
                for (int j = i; j < n; ++j)
                {
                    sum += nums[j];
                    present.Add(nums[j]);
                    if (present.Contains(sum))
                        result++;
                }
            }

            return result;
        }
    }
}

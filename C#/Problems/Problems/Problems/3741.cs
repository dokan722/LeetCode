using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3741 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 1, 2, 3, 2, 1, 2 };

            var expected = 8;

            var result = MinimumDistance(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinimumDistance(int[] nums)
        {
            var n = nums.Length;
            var pairs = new Dictionary<int, (int, int)>();
            var result = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (!pairs.ContainsKey(nums[i]))
                    pairs[nums[i]] = (i, i);
                else
                {
                    var pair = pairs[nums[i]];
                    if (pair.Item1 == pair.Item2)
                        pairs[nums[i]] = (pair.Item1, i);
                    else
                    {
                        result = Math.Min(result, 2 * (i - pair.Item1));
                        pairs[nums[i]] = (pair.Item2, i);
                    }
                }
            }

            return result == int.MaxValue ? -1 : result;
        }
    }
}

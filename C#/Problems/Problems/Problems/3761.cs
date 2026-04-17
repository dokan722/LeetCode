using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3761 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 12, 21, 45, 33, 54 };

            var expected = 1;

            var result = MinMirrorPairDistance(nums);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MinMirrorPairDistance(int[] nums)
        {
            var n = nums.Length;
            var result = int.MaxValue;
            var last = new Dictionary<int, int>();
            for (int i = 0; i < n; ++i)
            {
                var num = nums[i];
                if (last.ContainsKey(num))
                    result = Math.Min(result, i - last[num]);

                var rev = 0;
                while (num > 0)
                {
                    rev *= 10;
                    rev += num % 10;
                    num /= 10;
                }
                last[rev] = i;
            }

            return result == int.MaxValue ? -1 : result;
        }
    }
}

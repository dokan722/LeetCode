using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _448 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] {4, 3, 2, 7, 8, 2, 3, 1};

            var expected = new int[] { 5, 6 };

            var result = FindDisappearedNumbers(nums);

            Console.WriteLine(string.Join(", ", nums));

            return result.SequenceEqual(expected);
        }

        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var n = nums.Length;

            for (int i = 0; i < n; ++i)
            {
                var original = (nums[i] - 1) % n;
                if (nums[original] <= n)
                    nums[original] += n;
            }

            var result = new List<int>();

            for (int i = 0; i < n; ++i)
            {
                if (nums[i] <= n)
                    result.Add(i + 1);
            }

            return result;
        }
    }
}

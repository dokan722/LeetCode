using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _442 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 4, 3, 2, 7, 8, 2, 3, 1 };

            var expected = new[] { 2, 3 };

            var result = FindDuplicates(nums).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> FindDuplicates(int[] nums)
        {
            var n = nums.Length;
            var result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var id = Math.Abs(nums[i]) - 1;
                if (nums[id] < 0)
                    result.Add(Math.Abs(nums[i]));
                else
                    nums[id] = -nums[id];
            }

            return result;
        }
    }
}

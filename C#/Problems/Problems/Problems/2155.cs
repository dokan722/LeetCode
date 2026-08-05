using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2155 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 0, 0, 1, 0 };

            var expected = new[] { 4, 2 };

            var result = MaxScoreIndices(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> MaxScoreIndices(int[] nums)
        {
            var n = nums.Length;
            var zeros = new int[n];
            var cur = 0;
            for (int i = 0; i < n; ++i)
            {
                zeros[i] = cur;
                if (nums[i] == 0)
                    cur++;
            }
            var result = new List<int> { n };
            var mx = cur;
            cur = 0;
            for (int i = n - 1; i >= 0; --i)
            {
                if (nums[i] == 1)
                    cur++;
                var val = cur + zeros[i];
                if (val > mx)
                {
                    mx = val;
                    result.Clear();
                    result.Add(i);
                }
                else if (val == mx)
                    result.Add(i);
            }

            return result;
        }
    }
}

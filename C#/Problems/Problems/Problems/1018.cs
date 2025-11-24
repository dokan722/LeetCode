using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1018 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 0, 1, 1 };

            var expected = new[] { true, false, false };

            var result = PrefixesDivBy5(nums);

            Utils.Print1DArray(result.ToArray());

            return Utils.Compare1DArrays(result.ToArray(), expected);
        }

        public IList<bool> PrefixesDivBy5(int[] nums)
        {
            var n = nums.Length;
            var result = new List<bool>();
            var curr = 0;
            for (int i = 0; i < n; ++i)
            {
                curr = (2 * curr + nums[i]) % 10;
                result.Add(curr == 5 || curr == 0);
            }

            return result;
        }
    }
}

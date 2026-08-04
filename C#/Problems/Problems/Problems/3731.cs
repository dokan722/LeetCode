using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3731 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 4, 2, 5 };

            var expected = new[] { 3 };

            var result = FindMissingElements(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public IList<int> FindMissingElements(int[] nums)
        {
            var mx = nums[0];
            var mn = nums[0];
            foreach (var num in nums)
            {
                mx = Math.Max(mx, num);
                mn = Math.Min(mn, num);
            }
            var l = mx - mn + 1;
            var present = new bool[l];
            foreach (var num in nums)
                present[num - mn] = true;
            var result = new List<int>();
            for (int i = 0; i < l; ++i)
                if (!present[i])
                    result.Add(mn + i);
            return result;
        }
    }
}

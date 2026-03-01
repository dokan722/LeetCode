using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _15 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { -1, 0, 1, 2, -1, -4 };

            var expected = new[] { new[] { -1, -1, 2 }, new[] { -1, 0, 1 } };

            var result = ThreeSum(nums).Select(x => x.ToArray()).ToArray();

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var n = nums.Length;
            Array.Sort(nums);
            var result = new List<IList<int>>();
            for (int i = 0; i < n; ++i)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                var l = i + 1;
                var r = n - 1;
                while (l < r)
                {
                    var s = nums[i] + nums[l] + nums[r];
                    if (s == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[l], nums[r] });
                        l++;
                        r--;
                        while (l < r && nums[l] == nums[l - 1])
                            l++;
                    }
                    else if (s > 0)
                        r--;
                    else
                        l++;
                }
            }

            return result;
        }
    }
}

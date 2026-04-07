using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1630 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 10, -6, -7, 8, 16, 0, 0, 10, 20, 15, -2, -3, -1, -4, -4, -8, -2 };
            var l = new[] { 14, 5, 11, 15, 12, 13, 9, 7, 0 };
            var r = new[] { 15, 8, 14, 18, 15, 16, 12, 8, 1 };

            var expected = new[] { true, false, false, false, true, false, false, true, true };

            var result = CheckArithmeticSubarrays(nums, l, r);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
        {
            var m = l.Length;
            var result = new bool[m];
            for (int i = 0; i < m; ++i)
            {
                var mn = int.MaxValue;
                var mx = int.MinValue;
                for (int j = l[i]; j <= r[i]; ++j)
                {
                    mn = Math.Min(mn, nums[j]);
                    mx = Math.Max(mx, nums[j]);
                }
                var ln = r[i] - l[i] + 1;
                if (mn == mx)
                    result[i] = true;
                else if ((mx - mn) % (ln - 1) == 0)
                {
                    var present = new bool[ln];
                    var res = true;
                    var d = (mx - mn) / (ln - 1);
                    for (int j = l[i]; j <= r[i]; ++j)
                    {
                        if ((nums[j] - mn) % d != 0 || present[(nums[j] - mn) / d])
                        {
                            res = false;
                            break;
                        }

                        present[(nums[j] - mn) / d] = true;

                    }
                    result[i] = res;
                }
            }
            return result;
        }
    }
}

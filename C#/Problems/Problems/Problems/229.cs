using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _229 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 2 };

            var expected = new[] { 2 };

            var result = MajorityElement(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }
        public IList<int> MajorityElement(int[] nums)
        {
            var n = nums.Length;
            var k = 2;
            if (k >= n)
                return new HashSet<int>(nums).ToList();
            var cands = new int[k];
            var counts = new int[k];
            for (int i = 0; i < k; ++i)
                cands[i] = int.MinValue;
            for (int i = 0; i < n; ++i)
            {
                var present = false;
                for (int j = 0; j < k; ++j)
                {
                    if (nums[i] == cands[j])
                    {
                        counts[j]++;
                        present = true;
                        break;
                    }
                }
                var replaced = present;
                if (!present)
                {
                    for (int j = 0; j < k; ++j)
                    {
                        if (counts[j] == 0)
                        {
                            cands[j] = nums[i];
                            replaced = true;
                            counts[j] = 1;
                            break;
                        }
                    }
                }
                if (!replaced)
                {
                    for (int j = 0; j < k; ++j)
                        counts[j]--;
                }
            }
            var result = new List<int>();
            for (int i = 0; i < k; ++i)
                counts[i] = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < k; ++j)
                {
                    if (cands[j] != int.MinValue && cands[j] == nums[i])
                        counts[j]++;
                }
            }
            for (int i = 0; i < k; ++i)
            {
                if (counts[i] > n / 3)
                    result.Add(cands[i]);
            }

            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2948 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 5, 3, 9, 8 };
            var limit = 2;

            var expected = new[] { 1, 3, 5, 8, 9 };

            var result = LexicographicallySmallestArray(nums, limit);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] LexicographicallySmallestArray(int[] nums, int limit)
        {
            var n = nums.Length;
            var sorted = new int[n];
            Array.Copy(nums, sorted, n);
            Array.Sort(sorted);
            var groups = new List<Queue<int>>();
            groups.Add(new Queue<int>([sorted[0]]));
            var ass = new Dictionary<int, int>();
            ass[sorted[0]] = 0;
            var cur = 0;
            for (int i = 1; i < n; ++i)
            {
                if (sorted[i] - sorted[i - 1] > limit)
                {
                    groups.Add(new Queue<int>());
                    cur++;
                }
                ass[sorted[i]] = cur;
                groups[^1].Enqueue(sorted[i]);
            }

            for (int i = 0; i < n; ++i)
                sorted[i] = groups[ass[nums[i]]].Dequeue();


            return sorted;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3318 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 8, 7, 8, 7, 5 };
            var k = 2;
            var x = 2;

            var expected = new[] { 11, 15, 15, 15, 12 };

            var result = FindXSum(nums, k, x);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }
        public int[] FindXSum(int[] nums, int k, int x)
        {
            var n = nums.Length;
            var counts = new int[51];
            for (int i = 0; i < k; ++i)
                counts[nums[i]]++;

            var rLen = n - k + 1;
            var result = new int[rLen];
            for (int i = 0; i < rLen; ++i)
            {
                var cRes = 0;
                var que = new PriorityQueue<int, (int, int)>(Comparer<(int, int)>.Create((x, y) => y.CompareTo(x) ));
                for (int j = 0; j <= 50; ++j)
                    if (counts[j] > 0)
                        que.Enqueue(0, (counts[j], j));
                for (int j = 0; que.TryDequeue(out var _, out var count) && j < x; ++j)
                {
                    cRes += count.Item1 * count.Item2;
                }

                counts[nums[i]]--;
                if (i + k < n) 
                    counts[nums[i + k]]++;
                result[i] = cRes;
            }

            return result;
        }
    }
}

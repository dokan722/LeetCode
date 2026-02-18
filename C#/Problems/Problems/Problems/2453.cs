using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2453 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 7, 8, 1, 1, 5 };
            var space = 2;

            var expected = 1;

            var result = DestroyTargets(nums, space);

            Console.WriteLine(result);

            return result == expected;
        }

        public int DestroyTargets(int[] nums, int space)
        {
            var maxTargets = 0;
            var result = 0;
            var counts = new Dictionary<int, (int Smallest, int Count)>();
            foreach (var num in nums)
            {
                var rem = num % space;
                if (counts.ContainsKey(rem))
                {
                    var cur = counts[rem];
                    counts[rem] = (Math.Min(cur.Smallest, num), cur.Count + 1);
                }
                else
                {
                    counts[rem] = (num, 1);
                }
                var cand = counts[rem];
                if (cand.Count > maxTargets || (cand.Count == maxTargets && result > cand.Smallest))
                {
                    maxTargets = cand.Count;
                    result = cand.Smallest;
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _300 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 10, 9, 2, 5, 3, 7, 101, 18 };

            var expected = 4;

            var result = LengthOfLIS(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LengthOfLIS(int[] nums)
        {
            var subs = new List<int>();
            foreach (var num in nums)
            {
                var l = 0;
                var r = subs.Count - 1;
                var mid = 0;
                while (l <= r)
                {
                    mid = (l + r) / 2;
                    if (num > subs[mid])
                        l = mid + 1;
                    else
                        r = mid - 1;
                }
                if (l == subs.Count)
                    subs.Add(num);
                else
                    subs[l] = num;
            }

            return subs.Count;
        }
    }
}

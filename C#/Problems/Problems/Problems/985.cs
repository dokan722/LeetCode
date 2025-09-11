using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _985 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 4 };
            var queries = new[] { new[] { 1, 0 }, new[] { -3, 1 }, new[] { -4, 0 }, new[] { 2, 3 } };

            var expected = new[] { 8, 6, 2, 4 };

            var result = SumEvenAfterQueries(nums, queries);

            return result.SequenceEqual(expected);
        }

        public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
        {
            var n = nums.Length;
            var qn = queries.Length;
            var evenSum = 0;
            for (int i = 0; i < n; ++ i)
                if (nums[i] % 2 == 0)
                    evenSum += nums[i];


            var result = new int[qn];
            for (int i = 0; i <  qn; ++i)
            {
                var wasEven = nums[queries[i][1]] % 2 == 0;
                var willBeEven = (nums[queries[i][1]] % 2 == 0) == (queries[i][0] % 2 == 0);
                var newVal = nums[queries[i][1]] + queries[i][0];
                if (wasEven)
                {
                    if (willBeEven)
                        evenSum += queries[i][0];
                    else
                        evenSum -= nums[queries[i][1]];
                }
                else
                {
                    if (willBeEven)
                        evenSum += newVal;
                }
                nums[queries[i][1]] = newVal;
                result[i] = evenSum;
            }

            return result;
        }
    }
}

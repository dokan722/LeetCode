using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2197 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 6, 4, 3, 2, 7, 6, 2 };

            var expected = new List<int> { 12, 7, 6 };

            var result = ReplaceNonCoprimes(nums);

            return expected.SequenceEqual(result);
        }

        public IList<int> ReplaceNonCoprimes(int[] nums)
        {
            var result = new List<int>();
            foreach (var num in nums)
            {
                var next = num;
                while (result.Count > 0)
                {
                    var last = result[^1];
                    var gcd = Utils.GCD(last, next);
                    if (gcd == 1)
                        break;
                    next = (int)((long)last * next / gcd);
                    result.RemoveAt(result.Count - 1);
                }
                result.Add(next);
            }

            return result;
        }
    }
}

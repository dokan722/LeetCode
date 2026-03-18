using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _169 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 2, 3 };

            var expected = 3;

            var result = MajorityElement(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MajorityElement(int[] nums)
        {
            var cand = -1;
            var count = 0;
            foreach (var num in nums)
            {
                if (count == 0)
                {
                    count = 1;
                    cand = num;
                }
                else if (cand == num)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return cand;
        }
    }
}

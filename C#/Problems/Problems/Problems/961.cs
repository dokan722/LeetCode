using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _961 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 3 };

            var expected = 3;

            var result = RepeatedNTimes(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int RepeatedNTimes(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var num in nums)
            {
                if (set.Contains(num))
                    return num;
                set.Add(num);
            }

            return 0;
        }
    }
}

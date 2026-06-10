using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _217 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 1 };

            var expected = true;

            var result = ContainsDuplicate(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public bool ContainsDuplicate(int[] nums)
        {
            var s = new HashSet<int>();
            foreach (var n in nums)
            {
                if (s.Contains(n))
                    return true;
                s.Add(n);
            }
            return false;
        }
    }
}

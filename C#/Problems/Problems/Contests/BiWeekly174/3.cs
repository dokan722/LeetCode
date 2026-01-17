using Problems.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Contests.BiWeekly174
{
    public class _3 : IProblem
    {
        public bool Test()
        {
            var nums = new[] {2, 3, 1, 4};
            var target1 = 1;
            var target2 = 5;

            var expected = 1;

            var result = AlternatingXOR(nums, target1, target2);

            Console.WriteLine(result);

            return result == expected;
        }
        public int AlternatingXOR(int[] nums, int target1, int target2)
        {
            throw new NotImplementedException();
        }

    }
}

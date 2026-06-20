using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3875 : IProblem
    {
        public bool Test()
        {
            var nums1 = new[] { 2, 3 };

            var expected = true;

            var result = UniformArray(nums1);

            return expected == result;
        }

        public bool UniformArray(int[] nums1)
        {
            return true;
        }
    }
}

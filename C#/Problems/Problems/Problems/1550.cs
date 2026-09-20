using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1550 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 2, 6, 4, 1 };

            var expected = false;
            var result = ThreeConsecutiveOdds(arr);

            return expected == result;
        }

        public bool ThreeConsecutiveOdds(int[] arr)
        {
            var n = arr.Length;
            for (int i = 2; i < n; ++i)
            {
                if ((arr[i - 2] & 1) == 1 && (arr[i - 1] & 1) == 1 && (arr[i] & 1) == 1)
                    return true;
            }

            return false;
        }
    }
}

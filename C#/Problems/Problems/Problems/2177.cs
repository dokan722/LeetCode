using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2177 : IProblem
    {
        public bool Test()
        {
            var num = 33;

            var expected = new long[] { 10, 11, 12 };

            var result = SumOfThree(num);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public long[] SumOfThree(long num)
        {
            if (num % 3 != 0)
                return new long[] { };
            long mid = num / 3;
            return new long[] { mid - 1, mid, mid + 1 };
        }
    }
}

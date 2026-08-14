using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2178 : IProblem
    {
        public bool Test()
        {
            var finalSum = 12;

            var expected = new long[] { 2, 4, 6 };

            var result = MaximumEvenSplit(finalSum).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<long> MaximumEvenSplit(long finalSum)
        {
            var num = (long)((Math.Sqrt(4 * finalSum + 1) - 1) / 2);
            var result = new long[num];
            for (int i = 0; i < num; ++i)
                result[i] = 2 * i + 2;
            var bonus = finalSum - 2 * (num * (num + 1) / 2);
            if (bonus % 2 == 1)
                return new long[] { };
            result[num - 1] += bonus;
            return result;
        }
    }
}

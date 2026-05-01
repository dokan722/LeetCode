using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1291 : IProblem
    {
        public bool Test()
        {
            var low = 100;
            var high = 300;

            var expected = new[] { 123, 234 };

            var result = SequentialDigits(low, high);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> SequentialDigits(int low, int high)
        {
            var result = new List<int>();
            for (int i = 1; i < 10; ++i)
            {
                var num = 0;
                for (int j = i; j < 10; ++j)
                {
                    num *= 10;
                    num += j;
                    if (num < low)
                        continue;
                    if (num <= high)
                        result.Add(num);
                    else
                        break;
                }
            }

            result.Sort();
            return result;
        }
    }
}

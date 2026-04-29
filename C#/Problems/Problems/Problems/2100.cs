using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2100 : IProblem
    {
        public bool Test()
        {
            var security = new[] { 5, 3, 3, 3, 5, 6, 2 };
            var time = 2;

            var expected = new[] { 3, 2 };

            var result = GoodDaysToRobBank(security, time);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> GoodDaysToRobBank(int[] security, int time)
        {
            var n = security.Length;
            if (time == 0)
                return Enumerable.Range(0, n).ToArray();
            var before = new int[n];
            before[0] = 0;
            for (int i = 1; i < n; ++i)
            {
                if (security[i - 1] >= security[i])
                    before[i] = before[i - 1] + 1;
                else
                    before[i] = 0;
            }
            var after = 0;
            var result = new List<int>();
            for (int i = n - 2; i > 0; --i)
            {
                if (security[i + 1] >= security[i])
                    after++;
                else
                    after = 0;
                if (before[i] >= time && after >= time)
                    result.Add(i);
            }

            return result;
        }
    }
}

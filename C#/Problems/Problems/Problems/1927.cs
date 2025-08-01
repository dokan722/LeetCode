using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1927 : IProblem
    {
        public bool Test()
        {
            var num = "?3295???";

            var expected = false;

            var result = SumGame(num);

            return result == expected;
        }

        public bool SumGame(string num)
        {
            var n = num.Length;
            var q1 = 0;
            var q2 = 0;
            var sum1 = 0;
            var sum2 = 0;
            for (int i = 0; i < n / 2; ++i)
            {
                if (num[i] == '?')
                    q1++;
                else
                    sum1 += int.Parse(num[i].ToString());
            }
            for (int i = n / 2; i < n; ++i)
            {
                if (num[i] == '?')
                    q2++;
                else
                    sum2 += int.Parse(num[i].ToString());
            }



            if ((q1 + q2) % 2 == 0 && 2 * Math.Abs(sum1 - sum2) == Math.Abs(q1 - q2) * 9)
                return false;

            return true;
        }
    }
}

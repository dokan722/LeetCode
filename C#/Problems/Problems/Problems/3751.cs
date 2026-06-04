using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3751 : IProblem
    {
        public bool Test()
        {
            var num1 = 120;
            var num2 = 130;

            var expected = 3;

            var result = TotalWaviness(num1, num2);

            Console.WriteLine(result);

            return result == expected;
        }

        public int TotalWaviness(int num1, int num2)
        {
            var result = 0;
            var start = Math.Max(100, num1);
            for (int i = start; i <= num2; ++i)
            {
                var cur = i.ToString();
                var l = cur.Length;
                for (int j = 1; j < l - 1; ++j)
                {
                    if ((cur[j] < cur[j - 1] && cur[j] < cur[j + 1]) || (cur[j] > cur[j - 1] && cur[j] > cur[j + 1]))
                        result++;
                }
            }

            return result;
        }
    }
}

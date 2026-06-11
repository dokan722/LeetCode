using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _670 : IProblem
    {
        public bool Test()
        {
            var num = 2736;

            var expected = 7236;

            var result = MaximumSwap(num);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumSwap(int num)
        {
            var s = num.ToString();
            var n = s.Length;
            for (int i = 0; i < n; ++i)
            {
                var mx = i;
                for (int j = i + 1; j < n; ++j)
                    if (s[j] > s[i] && s[j] >= s[mx])
                        mx = j;
                if (i != mx)
                    return int.Parse(s.Substring(0, i) + s[mx] + s.Substring(i + 1, mx - i - 1) + s[i] + s.Substring(mx + 1));
            }

            return num;
        }
    }
}

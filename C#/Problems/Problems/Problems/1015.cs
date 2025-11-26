using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1015 : IProblem
    {
        public bool Test()
        {
            var k = 3;

            var expected = 3;

            var result = SmallestRepunitDivByK(k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SmallestRepunitDivByK(int k)
        {
            var num = 1;
            var seen = new HashSet<int>();
            for (int i = 0; i <= k; ++i)
            {
                num %= k;
                if (num == 0)
                    return i + 1;
                seen.Add(num);
                num = num * 10 + 1;
            }

            return -1;
        }
    }
}

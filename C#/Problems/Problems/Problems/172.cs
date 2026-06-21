using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _172 : IProblem
    {
        public bool Test()
        {
            var n = 3;

            var expected = 0;

            var result = TrailingZeroes(n);

            Console.WriteLine(result);

            return result == expected;
        }
        public int TrailingZeroes(int n)
        {
            var powers = new List<int>();
            var b = 5;
            while (b <= n)
            {
                powers.Add(b);
                b *= 5;
            }
            var result = 0;
            foreach (var f in powers)
                result += n / f;
            return result;
        }

    }
}

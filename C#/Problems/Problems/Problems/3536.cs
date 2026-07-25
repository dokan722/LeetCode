using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3536 : IProblem
    {
        public bool Test()
        {
            var n = 31;

            var expected = 3;

            var result = MaxProduct(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxProduct(int n)
        {
            var mx = 0;
            var mx2 = 0;
            while (n > 0)
            {
                var d = n % 10;
                n /= 10;
                if (d >= mx)
                {
                    mx2 = mx;
                    mx = d;
                }
                else if (d > mx2)
                    mx2 = d;
            }
            return mx * mx2;
        }
    }
}

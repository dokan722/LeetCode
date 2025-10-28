using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1492 : IProblem
    {
        public bool Test()
        {
            var n = 12;
            var k = 3;

            var expected = 3;

            var result = KthFactor(n, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int KthFactor(int n, int k)
        {
            var limit = Math.Sqrt(n);
            for (int i = 1; i < limit; ++i)
            {
                if (n % i == 0)
                {
                    k--;
                    if (k == 0)
                        return i;
                }
                    
            }


            for (int i = (int)limit; i > 0; --i)
            {
                var div = n / i;
                if (n % div == 0)
                {
                    k--;
                    if (k == 0)
                        return div;
                }

            }

            return -1;
        }
    }
}

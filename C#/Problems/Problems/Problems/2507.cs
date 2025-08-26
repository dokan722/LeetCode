using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2507 : IProblem
    {
        public bool Test()
        {
            var n = 15;

            var expected = 5;

            var result = SmallestValue(n);

            Console.WriteLine(result);

            return expected == result;
        }

        public int SmallestValue(int n)
        {
            var next = n;
            var prev = 0;
            while (next > 0)
            {
                int i = 2;
                n = next;
                if (prev == next)
                    return prev;
                prev = next;
                next = 0;
                var limit = n / 2;
                while (i <= limit && n > 1)
                {
                    if (n % i == 0)
                    {
                        n /= i;
                        next += i;
                        i = 2;
                    }
                    else
                        i++;
                }
            }

            return n;
        }
    }
}

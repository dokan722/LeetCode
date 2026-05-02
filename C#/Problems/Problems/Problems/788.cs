using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _788 : IProblem
    {
        public bool Test()
        {
            var n = 10;

            var expected = 4;

            var result = RotatedDigits(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int RotatedDigits(int n)
        {
            var result = 0;

            for (int i = 1; i <= n; ++i)
            {
                var num = i;
                var changed = false;
                while (num > 0)
                {
                    var r = num % 10;
                    if (r == 3 || r == 4 || r == 7)
                    {
                        changed = false;
                        break;
                    }
                    if (r == 5 || r == 2 || r == 6 || r == 9)
                        changed = true;
                    num /= 10;
                }

                if (changed)
                    result++;
            }

            return result;
        }
    }
}

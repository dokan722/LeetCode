using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1006 : IProblem
    {
        public bool Test()
        {
            var n = 10;

            var expected = 12;

            var result = Clumsy(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int Clumsy(int n)
        {
            var times = (n / 4) - 1;
            var rest = n % 4;
            var curr = 0;
            if (n >= 4)
            {
                curr += n * (n - 1) / (n - 2) + (n - 3);
                for (int i = 0; i < times; i++)
                {
                    var num = n - (i + 1) * 4;
                    curr -= num * (num - 1) / (num - 2) - (num - 3);
                }

                if (rest == 3)
                    curr -= 6;
                else if (rest == 2)
                    curr -= 2;
                else if (rest == 1)
                    curr -= 1;
            }
            else
            {
                if (rest == 3)
                    curr += 6;
                else if (rest == 2)
                    curr += 2;
                else if (rest == 1)
                    curr += 1;
            }

            return curr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1529 : IProblem
    {
        public bool Test()
        {
            var target = "10111";

            var expected = 3;

            var result = MinFlips(target);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinFlips(string target)
        {
            var waitingZero = false;
            var count = 0;
            foreach (var c in target)
            {
                if (c == '1')
                    waitingZero = true;
                else
                {
                    if (waitingZero)
                        count++;
                    waitingZero = false;
                }
            }

            return 2 * count + (waitingZero ? 1 : 0);
        }
    }
}

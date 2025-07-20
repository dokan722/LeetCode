using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1732 : IProblem
    {
        public bool Test()
        {
            var gain = new[] { -5, 1, 5, 0, -7 };

            var expected = 1;

            var result = LargestAltitude(gain);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LargestAltitude(int[] gain)
        {
            var att = 0;
            var maxAtt = 0;
            foreach (var i in gain)
            {
                att += i;
                if (att > maxAtt)
                    maxAtt = att;
            }

            return maxAtt;
        }
    }
}

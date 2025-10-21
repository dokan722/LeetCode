using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2864 : IProblem
    {
        public bool Test()
        {
            var s = "0101";

            var expected = "1001";

            var result = MaximumOddBinaryNumber(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public string MaximumOddBinaryNumber(string s)
        {
            var zeros = 0;
            var ones = 0;
            foreach (var c in s)
            {
                if (c == '0')
                    zeros++;
                else
                    ones++;
            }

            return new string('1', ones - 1) + new string('0', zeros) + '1';
        }
    }
}

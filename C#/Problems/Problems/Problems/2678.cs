using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2678 : IProblem
    {
        public bool Test()
        {
            var details = new[] { "7868190130M7522", "5303914400F9211", "9273338290F4010" };

            var expected = 2;

            var result = CountSeniors(details);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountSeniors(string[] details)
        {
            var result = 0;
            foreach (var d in details)
                if (d[11] > '6' || (d[11] == '6' && d[12] > '0'))
                    result++;
            return result;
        }
    }
}

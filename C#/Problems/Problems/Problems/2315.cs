using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2315 : IProblem
    {
        public bool Test()
        {
            var s = "l|*e*et|c**o|*de|";

            var expected = 2;

            var result = CountAsterisks(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountAsterisks(string s)
        {
            var result = 0;
            var count = 0;
            var inside = false;
            foreach (var c in s)
            {
                if (c == '*')
                    count++;
                else if (c == '|')
                {
                    if (!inside)
                        result += count;
                    count = 0;
                    inside = !inside;
                }
            }

            result += count;

            return result;
        }
    }
}

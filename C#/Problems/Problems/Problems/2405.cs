using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2405 : IProblem
    {
        public bool Test()
        {
            var s = "abacaba";

            var expected = 4;

            var result = PartitionString(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int PartitionString(string s)
        {
            var n = s.Length;
            var present = new bool[26];
            var result = 1;

            for (int i = 0; i < n; i++)
            {
                var id = s[i] - 'a';
                if (present[id])
                {
                    result++;
                    present = new bool[26];
                }
                present[id] = true;
            }

            return result;
        }
    }
}

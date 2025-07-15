using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1419 : IProblem
    {
        public bool Test()
        {
            var croakOfFrogs = "crcoakroak";

            var expected = 2;

            var result = MinNumberOfFrogs(croakOfFrogs);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinNumberOfFrogs(string croakOfFrogs)
        {
            var croak = "croak";
            var ids = new Dictionary<char, int> { { 'c', 0 }, { 'r', 1 }, { 'o', 2 }, { 'a', 3 }, { 'k', 4 } };
            var counts = new int[5];
            var maxFrogs = 0;
            foreach (var c in croakOfFrogs)
            {
                counts[ids[c]]++;
                if (c != 'c' && counts[ids[c]] > counts[ids[c] - 1])
                    return -1;
                if (c == 'k')
                {
                    var frogsNow = counts[0] - counts[4] + 1;
                    if (frogsNow > maxFrogs)
                        maxFrogs = frogsNow;
                }
            }
            var expectedCount = counts[0];
            for (int i = 1; i < 5; ++i)
                if (counts[i] != expectedCount)
                    return -1;

            return maxFrogs;
        }
    }
}

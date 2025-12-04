using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2211 : IProblem
    {
        public bool Test()
        {
            var directions = "RLRSLL";

            var expected = 5;

            var result = CountCollisions(directions);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountCollisions(string directions)
        {
            var n = directions.Length;
            int start = 0, end = n - 1;
            while (start < n && directions[start] == 'L')
                start++;
            while (end >= 0 && directions[end] == 'R')
                end--;
            var result = 0;
            for (int i = start; i <= end;  i++)
                if (directions[i] != 'S')
                    result++;
            return result;
        }
    }
}

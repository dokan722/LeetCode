using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1386 : IProblem
    {
        public bool Test()
        {
            var n = 3;
            var reservedSeats = new[] { new[] { 1, 2 }, new[] { 1, 3 }, new[] { 1, 8 }, new[] { 2, 6 }, new[] { 3, 1 }, new[] { 3, 10 } };

            var expected = 4;

            var result = MaxNumberOfFamilies(n, reservedSeats);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxNumberOfFamilies(int n, int[][] reservedSeats)
        {
            var occupied = new Dictionary<int, int>();
            foreach (var r in reservedSeats)
            {
                int cur;
                if (occupied.ContainsKey(r[0]))
                    cur = occupied[r[0]];
                else
                    cur = 7;
                if (r[1] > 1 && r[1] < 6)
                    cur &= 6;
                if (r[1] > 3 && r[1] < 8)
                    cur &= 5;
                if (r[1] > 5 && r[1] < 10)
                    cur &= 3;
                occupied[r[0]] = cur;
            }
            var result = 2 * n;
            foreach (var row in occupied)
            {
                var state = row.Value;
                if (state == 0)
                    result -= 2;
                else if (state != 7 && state != 5)
                    result -= 1;
            }

            return result;
        }
    }
}

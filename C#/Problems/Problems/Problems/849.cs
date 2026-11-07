using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _849 : IProblem
    {
        public bool Test()
        {
            var seats = new[] { 1, 0, 0, 0, 1, 0, 1 };

            var expected = 2;

            var result = MaxDistToClosest(seats);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxDistToClosest(int[] seats)
        {
            var n = seats.Length;
            var l = 0;
            var r = n - 1;
            while (seats[l] != 1)
                l++;
            while (seats[r] != 1)
                r--;
            var result = Math.Max(l, n - 1 - r);
            if (l != r)
            {
                var prev = l;
                for (int i = l + 1; i <= r; ++i)
                {
                    if (seats[i] == 1)
                    {
                        var free = i - prev - 1;
                        if (free > 0)
                            result = Math.Max(result, (free - 1) / 2 + 1);
                        prev = i;
                    }
                }
            }
            return result;
        }
    }
}

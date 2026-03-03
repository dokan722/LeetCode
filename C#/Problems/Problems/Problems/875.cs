using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _875 : IProblem
    {
        public bool Test()
        {
            var piles = new[] { 30, 11, 23, 4, 20 };
            var h = 5;

            var expected = 30;

            var result = MinEatingSpeed(piles, h);

            Console.WriteLine(result);

            return result == expected;
        }


        public int MinEatingSpeed(int[] piles, int h)
        {
            var n = piles.Length;
            var l = 1;
            var r = 0;
            foreach (var pile in piles)
                r = Math.Max(pile, r);
            while (l < r)
            {
                var mid = (l + r) / 2;
                var valid = true;
                var t = 0;
                var i = 0;
                while (t <= h && i < n)
                {
                    t += (piles[i] + mid - 1) / mid;
                    i++;
                }
                valid = (i == n && t <= h);

                if (valid)
                    r = mid;
                else
                    l = mid + 1;
            }

            return l;
        }
    }
}

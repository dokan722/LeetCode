using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _605 : IProblem
    {
        public bool Test()
        {
            var flowerbed = new[] { 1, 0, 0, 0, 1 };
            var n = 1;

            var expected = true;

            var result = CanPlaceFlowers(flowerbed, n);

            return result == expected;
        }

        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            var m = flowerbed.Length;
            var last = -2;
            for (int i = 0; i < m; ++i)
            {
                if (flowerbed[i] == 1)
                {
                    var l = i - last - 1;
                    last = i;
                    n -= (l - 1) / 2;
                }
            }
            n -= (m - last - 1) / 2;
            return n <= 0;
        }
    }
}

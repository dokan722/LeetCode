using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1356 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

            var expected = new int[] { 0, 1, 2, 4, 8, 3, 5, 6, 7 };

            var result = SortByBits(nums);

            return expected.SequenceEqual(result);
        }

        public int[] SortByBits(int[] arr)
        {
            Array.Sort(arr, new BitComparer());
            return arr;
        }

        private class BitComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                var xBits = BitOperations.PopCount((uint)x);
                var yBits = BitOperations.PopCount((uint)y);

                var bitCompare = xBits.CompareTo(yBits);

                if (bitCompare != 0)
                    return bitCompare;
                return x.CompareTo(y);
            }


            // SLOW
            //private int CountBits(int n)
            //{
            //    var count = 0;

            //    while (n > 0)
            //    {
            //        count += n % 2;
            //        n /= 2;
            //    }

            //    return count;
            //}
        }
    }
}

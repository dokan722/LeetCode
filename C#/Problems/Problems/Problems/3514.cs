using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3514 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 6, 7, 8, 9 };

            var expected = 4;

            var result = UniqueXorTriplets(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int UniqueXorTriplets(int[] nums)
        {
            var mx = 0;
            foreach (var num in nums)
                mx = Math.Max(num, mx);
            var s = 1;
            while (s <= mx)
                s <<= 1;
            var one = new bool[s];
            var two = new bool[s];
            var three = new bool[s];
            foreach (var num in nums)
            {
                one[num] = true;
                for (int i = 0; i < s; ++i)
                    if (one[i])
                        two[i ^ num] = true;
            }
            foreach (var num in nums)
            {
                for (int i = 0; i < s; ++i)
                    if (two[i])
                        three[i ^ num] = true;
            }
            var result = 0;
            for (int i = 0; i < s; ++i)
                if (three[i])
                    result++;
            return result;
        }
    }
}

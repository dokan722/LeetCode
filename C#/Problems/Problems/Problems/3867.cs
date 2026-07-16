using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3867 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 6, 4 };

            var expected = 2;

            var result = GcdSum(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long GcdSum(int[] nums)
        {
            var n = nums.Length;
            var prefs = new int[n];
            var mx = 0;
            for (int i = 0; i < n; ++i)
            {
                mx = Math.Max(mx, nums[i]);
                prefs[i] = Gcd(mx, nums[i]);
            }
            Array.Sort(prefs);
            long result = 0;
            for (int i = 0; i < n / 2; ++i)
            {
                result += Gcd(prefs[i], prefs[n - 1 - i]);
            }
            return result;
        }

        private int Gcd(int a, int b)
        {
            if (b > a)
                (a, b) = (b, a);
            while (b != 0)
            {
                a %= b;
                (a, b) = (b, a);
            }

            return a;
        }
    }
}

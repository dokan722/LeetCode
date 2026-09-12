using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3483 : IProblem
    {
        public bool Test()
        {
            var digits = new[] { 1, 2, 3, 4 };

            var expected = 12;

            var result = TotalNumbers(digits);

            Console.WriteLine(result);

            return result == expected;
        }

        public int TotalNumbers(int[] digits)
        {
            var freq = new int[10];
            int res = 0;

            foreach (var d in digits)
                freq[d]++;

            for (int i = 1; i < 10; i++)
            for (int j = 0; j < 10; j++)
            for (int k = 0; k < 9; k += 2)
                res += (freq[i] > 0 && freq[j] > (i == j ? 1 : 0) && freq[k] > (i == k ? 1 : 0) + (j == k ? 1 : 0)) ? 1 : 0;


            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _66 : IProblem
    {
        public bool Test()
        {
            var digits = new[] { 1, 2, 3 };

            var expected = new[] { 1, 2, 4 };

            var result = PlusOne(digits);
            
            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public int[] PlusOne(int[] digits)
        {
            var n = digits.Length;
            var i = n - 1;
            while (i >= 0 && digits[i] == 9)
                i--;
            if (i == -1)
            {
                var result = new int[n + 1];
                result[0] = 1;
                return result;
            }

            digits[i]++;
            for (int j = i + 1; j < n; ++j)
                digits[j] = 0;

            return digits;
        }
    }
}

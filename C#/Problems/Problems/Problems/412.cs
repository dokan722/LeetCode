using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _412 : IProblem
    {
        public bool Test()
        {
            var n = 5;

            var expected = new string[] { "1", "2", "Fizz", "4", "Buzz" };

            var result = FizzBuzz(n).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<string> FizzBuzz(int n)
        {
            var result = new string[n];
            for (int i = 1; i <= n; ++i)
            {
                if (i % 15 == 0)
                    result[i - 1] = "FizzBuzz";
                else if (i % 3 == 0)
                    result[i - 1] = "Fizz";
                else if (i % 5 == 0)
                    result[i - 1] = "Buzz";
                else
                    result[i - 1] = i.ToString();
            }

            return result;
        }
    }
}

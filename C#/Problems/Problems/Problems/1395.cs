using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1395 : IProblem
    {
        public bool Test()
        {
            var rating = new[] { 2, 5, 3, 4, 1 };

            var expected = 3;

            var result = NumTeams(rating);

            Console.WriteLine(result);

            return result == expected;
        }
        public int NumTeams(int[] rating)
        {
            var n = rating.Length;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                var smaller1 = 0;
                var bigger1 = 0;
                for (int j = 0; j < i; ++j)
                {
                    if (rating[j] < rating[i])
                        smaller1++;
                    if (rating[j] > rating[i])
                        bigger1++;
                }
                var smaller2 = 0;
                var bigger2 = 0;
                for (int j = i + 1; j < n; ++j)
                {
                    if (rating[j] < rating[i])
                        smaller2++;
                    if (rating[j] > rating[i])
                        bigger2++;
                }
                result += smaller1 * bigger2 + smaller2 * bigger1;
            }

            return result;
        }
    }
}

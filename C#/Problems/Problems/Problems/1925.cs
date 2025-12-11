using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1925 : IProblem
    {
        public bool Test()
        {
            var n = 10;

            var expected = 4;

            var result = CountTriples(n);

            Console.WriteLine(result);

            return result == expected;

        }

        public int CountTriples(int n)
        {
            var squares = new HashSet<int>();
            for (int i = 1; i <=n; ++i)
                squares.Add(i * i);
            var result = 0;
            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= n; ++j)
                {
                    if (squares.Contains(i * i + j * j))
                        result++;
                }
            }

            return result;
        }
    }
}

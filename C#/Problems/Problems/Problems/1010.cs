using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1010 : IProblem
    {
        public bool Test()
        {
            var time = new[] { 30, 20, 150, 100, 40 };

            var expected = 3;

            var result = NumPairsDivisibleBy60(time);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumPairsDivisibleBy60(int[] time)
        {
            int n = time.Length;
            var rests = new int[60];
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                int rest = time[i] % 60;
                int expected = (60 - rest) % 60;
                result += rests[expected];
                rests[rest]++;
            }

            return result;
        }
    }
}

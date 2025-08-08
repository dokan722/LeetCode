using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1014 : IProblem
    {
        public bool Test()
        {
            var values = new[] { 8, 1, 5, 2, 6 };

            var expected = 11;

            var result = MaxScoreSightseeingPair(values);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxScoreSightseeingPair(int[] values)
        {
            var maxPrev = 0;
            var result = int.MinValue;
            for (int i = 1; i < values.Length; i++)
            {
                var dist = i - maxPrev;
                var value = values[i] + values[maxPrev] - dist;
                if (value > result)
                    result = value;
                if (values[maxPrev] - dist < values[i])
                    maxPrev = i;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public  class _739 : IProblem
    {
        public bool Test()
        {
            var temperatures = new[] { 73, 74, 75, 71, 69, 72, 76, 73 };

            var expected = new[] { 1, 1, 4, 2, 1, 1, 0, 0 };

            var result = DailyTemperatures(temperatures);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] DailyTemperatures(int[] temperatures)
        {
            var n = temperatures.Length;
            var result = new int[n];
            var temps = new Stack<(int, int)>();

            for (int i = n - 1; i >= 0; --i)
            {
                var count = 1;
                while (temps.Count > 0 && temperatures[i] >= temps.Peek().Item1)
                {
                    count += temps.Peek().Item2;
                    temps.Pop();
                }
                result[i] = temps.Count == 0 ? 0 : count;
                temps.Push((temperatures[i], result[i]));
            }

            return result;
        }
    }
}

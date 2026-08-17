using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _4025 : IProblem
    {
        public bool Test()
        {
            var period = 8;
            var lights = new[] { 2, 3 };
            var arrivalTime = new[] { 2, 5, 8, 11 };

            var expected = 5;

            var result = MinPenalty(period, lights, arrivalTime);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinPenalty(int period, int[] lights, int[] arrivalTime)
        {
            var mx = 0;
            foreach (var l in lights)
                mx = Math.Max(mx, l);
            var result = 0;
            foreach (var a in arrivalTime)
            {
                var r = a % period;
                if (r >= mx)
                    result = Math.Max(result, period - r);
            }

            return result;
        }
    }
}

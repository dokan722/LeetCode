using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1184 : IProblem
    {
        public bool Test()
        {
            var distance = new[] {1, 2, 3, 4};
            var start = 0;
            var destination = 1;

            var expected = 1;

            var result = DistanceBetweenBusStops(distance, start, destination);

            Console.WriteLine(result);

            return expected == result;
        }

        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            var n = distance.Length;
            var clock = 0;
            var counter = 0;
            var left = Math.Min(start, destination);
            var right = Math.Max(start, destination);
            for (int i = 0; i < n; ++i)
            {
                if (i >= left && i < right)
                    clock += distance[i];
                else
                    counter += distance[i];
            }

            return Math.Min(clock, counter);
        }
    }
}

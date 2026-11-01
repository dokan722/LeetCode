using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _4024 : IProblem
    {
        public bool Test()
        {
            var drones = new[] {new[] {0, 0, 8}, new[] {2, 2, 9}};
            var target = new[] { 3, 4 };

            var expected = 1;

            var result = NearestDrone(drones, target);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NearestDrone(int[][] drones, int[] target)
        {
            var n = drones.Length;
            var mn = int.MaxValue;
            var result = -1;
            for (int i = 0; i < n; ++i)
            {
                var drone = drones[i];
                var dist = Math.Abs(drone[0] - target[0]) + Math.Abs(drone[1] - target[1]);
                if (dist <= drone[2] && dist < mn)
                {
                    mn = dist;
                    result = i;
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3638 : IProblem
    {
        public bool Test()
        {
            var weight = new[] { 2, 5, 1, 4, 3 };

            var expected = 2;

            var result = MaxBalancedShipments(weight);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxBalancedShipments(int[] weight)
        {
            var result = 0;
            var m = 0;
            foreach (var w in weight)
            {
                m = Math.Max(m, w);
                if (w < m)
                {
                    result++;
                    m = 0;
                }
            }
            return result;
        }
    }
}

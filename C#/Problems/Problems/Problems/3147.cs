using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3147 : IProblem
    {
        public bool Test()
        {
            var energy = new[] { 5, 2, -10, -5, 1 };
            var k = 3;

            var expected = 3;

            var result = MaximumEnergy(energy, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaximumEnergy(int[] energy, int k)
        {
            var n = energy.Length;
            var result = int.MinValue;
            for (int i = 0; i < n; ++i)
            {
                if (i + k < n)
                    energy[i + k] = Math.Max(energy[i + k], energy[i + k] + energy[i]);
                else
                    result = Math.Max(result, energy[i]);
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3285 : IProblem
    {
        public bool Test()
        {
            var height = new[] { 1, 2, 3, 4, 5 };
            var threshold = 2;

            var expected = new[] { 3, 4 };

            var result = StableMountains(height, threshold).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> StableMountains(int[] height, int threshold)
        {
            var n = height.Length;
            var result = new List<int>();
            for (int i = 0; i < n - 1; ++i)
            {
                if (height[i] > threshold)
                    result.Add(i + 1);
            }

            return result;
        }
    }
}

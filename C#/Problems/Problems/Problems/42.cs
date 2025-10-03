using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _42 : IProblem
    {
        public bool Test()
        {
            var height = new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            var expected = 6;

            var result = Trap(height);

            Console.WriteLine(result);

            return expected == result;
        }

        public int Trap(int[] height)
        {
            var n = height.Length;
            var maxId = 0;
            var result = 0;
            var waterCollected = 0;
            for (int i = 1; i < n; ++i)
            {
                if (height[i] >= height[maxId])
                {
                    result += waterCollected;
                    waterCollected = 0;
                    maxId = i;
                }
                else
                {
                    waterCollected += height[maxId] - height[i];
                }
            }

            var border = maxId;
            maxId = n - 1;
            waterCollected = 0;
            for (int i = n - 2; i >= border; --i)
            {
                if (height[i] >= height[maxId])
                {
                    result += waterCollected;
                    waterCollected = 0;
                    maxId = i;
                }
                else
                {
                    waterCollected += height[maxId] - height[i];
                }
            }


            return result;
        }
    }
}

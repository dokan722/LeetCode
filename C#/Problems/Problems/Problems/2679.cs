using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2679 : IProblem
    {
        public bool Test()
        {
            var matrix = new int[][] { new int[] { 7, 2, 1 }, new int[] { 6, 4, 2 }, new int[] { 6, 5, 3 }, new int[] { 3, 2, 1 } };

            var expected = 15;

            var result = MatrixSum(matrix);

            Console.WriteLine(result);

            return expected == result;
        }
        public int MatrixSum(int[][] nums)
        {
            var n = nums.Length;
            var m = nums[0].Length;
            for (int i = 0; i < n; ++i)
            {
                Array.Sort(nums[i]);
            }

            var result = 0;

            for (int i = 0; i < m; ++i)
            {
                var max = 0;
                for (int j = 0; j < n; ++j)
                {
                    if (nums[j][i] > max)
                        max = nums[j][i];
                }
                result += max;
            }

            return result;
        }
    }
}

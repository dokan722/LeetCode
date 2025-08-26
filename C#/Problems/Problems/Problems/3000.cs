using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3000 : IProblem
    {
        public bool Test()
        {
            var dimensions = new[] { new[] { 9, 3 }, new[] { 8, 6 } };

            var expected = 48;

            var result = AreaOfMaxDiagonal(dimensions);

            Console.WriteLine(result);

            return expected == result;
        }

        public int AreaOfMaxDiagonal(int[][] dimensions)
        {
            var maxDia = 0;
            var maxArea = 0;
            for (int i = 0; i < dimensions.Length; ++i)
            {
                var dia = dimensions[i][0] * dimensions[i][0] + dimensions[i][1] * dimensions[i][1];
                if (dia > maxDia)
                {
                    maxDia = dia;
                    maxArea = dimensions[i][0] * dimensions[i][1];
                }
                else if (dia == maxDia)
                    maxArea = Math.Max(maxArea, dimensions[i][0] * dimensions[i][1]);
            }

            return maxArea;
        }
    }
}

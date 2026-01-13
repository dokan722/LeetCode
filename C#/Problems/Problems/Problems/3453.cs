using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3453 : IProblem
    {
        public bool Test()
        {
            var squares = new[] { new[] { 0, 0, 2 }, new[] { 1, 1, 1 } };

            var expected = 1.16667;

            var result = SeparateSquares(squares);

            Console.WriteLine(result);

            return Math.Abs(result - expected) < 1e-5;
        }

        public double SeparateSquares(int[][] squares)
        {
            var bot = double.MaxValue;
            var top = double.MinValue;

            foreach (var square in squares)
            {
                bot = Math.Min(bot, square[1]);
                top = Math.Max(top, square[1] + square[2]);
            }

            while (Math.Abs(bot - top) > 1e-5)
            {
                var mid = (bot + top) / 2;
                double below = 0;
                double above = 0;
                foreach (var square in squares)
                {
                    var z = Math.Max(0, Math.Min(square[2], mid - square[1]));
                    below += z * square[2];
                    above += (square[2] - z) * square[2];
                }

                if (below >= above)
                    top = mid;
                else
                    bot = mid;
            }

            return bot;
        }
    }
}

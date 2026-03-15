using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _735 : IProblem
    {
        public bool Test()
        {
            var asteroids = new[] { 3, 5, -6, 2, -1, 4 };

            var expected = new[] { -6, 2, 4 };

            var result = AsteroidCollision(asteroids);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] AsteroidCollision(int[] asteroids)
        {
            var n = asteroids.Length;
            var train = new Stack<int>();
            var leftAst = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                if (asteroids[i] > 0)
                    train.Push(asteroids[i]);
                else
                {
                    var mass = Math.Abs(asteroids[i]);
                    while (train.Count > 0 && train.Peek() < mass)
                        train.Pop();
                    if (train.Count == 0)
                        leftAst.Add(asteroids[i]);
                    else if (train.Peek() == mass)
                        train.Pop();
                }
            }
            var resultLen = train.Count + leftAst.Count;
            var result = new int[resultLen];
            for (int i = 0; i < leftAst.Count; ++i)
                result[i] = leftAst[i];
            var k = 1;
            while (train.Count > 0)
            {
                result[resultLen - k] = train.Pop();
                k++;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3522 : IProblem
    {
        public bool Test()
        {
            var instructions = new string[] {"jump", "add", "add", "jump", "add", "jump"};

            var values = new int[] { 2, 1, 3, 1, -2, -3 };

            var expected = 1;

            var result = CalculateScore(instructions, values);

            Console.WriteLine(result);

            return result == expected;
        }

        public long CalculateScore(string[] instructions, int[] values)
        {
            int i = 0;
            var n = instructions.Length;
            var visited = new bool[n];
            long score = 0;
            while (i >= 0 && i < n && !visited[i])
            {
                if (instructions[i] == "add")
                {
                    visited[i] = true;
                    score += values[i];
                    i++;
                }
                else
                {
                    visited[i] = true;
                    i += values[i];
                }
            }

            return score;
        }
    }
}

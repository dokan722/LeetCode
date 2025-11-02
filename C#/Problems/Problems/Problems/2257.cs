using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2257 : IProblem
    {
        public bool Test()
        {
            int m = 4;
            int n = 6;
            var guards = new[] { new[] { 0, 0 }, new[] { 1, 1 }, new[] { 2, 3 } };
            var walls = new[] { new[] { 0, 1 }, new[] { 2, 2 }, new[] { 1, 4 } };

            var expected = 7;

            var result = CountUnguarded(m, n, guards, walls);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
        {
            var prison = new int[m][];
            for (int i = 0; i < m; ++i)
                prison[i] = new int[n];
            foreach (var guard in guards)
                prison[guard[0]][guard[1]] = 2;
            foreach (var wall in walls)
                prison[wall[0]][wall[1]] = 3;
            for (int i = 0; i < m; ++i)
            {
                var state = false;
                for (int j = 0; j < n; ++j)
                    state = CheckCell(i, j, state, prison);
                state = false;
                for (int j = n - 1; j >= 0; --j)
                    state = CheckCell(i, j, state, prison);
            }
            for (int i = 0; i < n; ++i)
            {
                var state = false;
                for (int j = 0; j < m; ++j)
                    state = CheckCell(j, i, state, prison);
                state = false;
                for (int j = m - 1; j >= 0; --j)
                    state = CheckCell(j, i, state, prison);
            }

            var result = 0;
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                    if (prison[i][j] == 0)
                        result += 1;
            }

            return result;
        }

        private bool CheckCell(int i, int j, bool state, int[][] prison)
        {
            var val = prison[i][j];
            if (val == 2)
                state = true;
            else if (val == 3)
                state = false;
            else if (state)
                prison[i][j] = 1;
            return state;
        }
    }
}

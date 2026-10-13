using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _79 : IProblem
    {
        public bool Test()
        {
            var board = new[]
                { new[] { 'A', 'B', 'C', 'E' }, new[] { 'S', 'F', 'C', 'S' }, new[] { 'A', 'D', 'E', 'E' } };
            var word = "ABCCED";

            var expected = true;

            var result = Exist(board, word);

            return expected == result;
        }
        public bool Exist(char[][] board, string word)
        {
            var n = board.Length;
            var m = board[0].Length;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    var visited = new bool[n][];
                    for (int k = 0; k < n; ++k)
                        visited[k] = new bool[m];
                    if (FindWord(board, n, m, word.Length, word, 0, i, j, visited))
                        return true;
                }
            }

            return false;
        }

        private bool FindWord(char[][] board, int n, int m, int l, string word, int id, int x, int y, bool[][] visited)
        {
            if (x < 0 || x >= n || y < 0 || y >= m || visited[x][y] || board[x][y] != word[id])
                return false;
            visited[x][y] = true;
            if (id + 1 == l)
                return true;
            if (FindWord(board, n, m, l, word, id + 1, x - 1, y, visited)
                || FindWord(board, n, m, l, word, id + 1, x + 1, y, visited)
                || FindWord(board, n, m, l, word, id + 1, x, y + 1, visited)
                || FindWord(board, n, m, l, word, id + 1, x, y - 1, visited))
                return true;
            visited[x][y] = false;
            return false;
        }

    }
}

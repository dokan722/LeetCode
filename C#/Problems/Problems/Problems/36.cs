using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _36 : IProblem
    {
        public bool Test()
        {
            var board = new[]
            {
                new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            var expected = true;

            var result = IsValidSudoku(board);

            return expected == result;
        }

        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                var rowNums = new List<char>();
                var colNums = new List<char>();
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (rowNums.Contains(board[i][j]))
                            return false;
                        rowNums.Add(board[i][j]);
                    }
                    if (board[j][i] != '.')
                    {
                        if (colNums.Contains(board[j][i]))
                            return false;
                        colNums.Add(board[j][i]);
                    }
                }
            }

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; j++)
                {
                    var partNums = new List<char>();
                    var row = i * 3;
                    var col = j * 3;
                    for (int k = 0; k < 3; ++k)
                    {
                        for (int l = 0; l < 3; ++l)
                        {
                            if (board[row + k][col + l] != '.')
                            {
                                if (partNums.Contains(board[row + k][col + l]))
                                    return false;
                                partNums.Add(board[row + k][col + l]);
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}

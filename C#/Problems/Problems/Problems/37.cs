﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _37 : IProblem
    {
        public bool Test()
        {
            var board = new[] {new[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'}, new[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'}, new[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'}, new[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'}, new[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'}, new[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'}, new[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'}, new[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'}, new[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}};

            var expected = new[] {new[] {'5', '3', '4', '6', '7', '8', '9', '1', '2'}, new[] {'6', '7', '2', '1', '9', '5', '3', '4', '8'}, new[] {'1', '9', '8', '3', '4', '2', '5', '6', '7'}, new[] {'8', '5', '9', '7', '6', '1', '4', '2', '3'}, new[] {'4', '2', '6', '8', '5', '3', '7', '9', '1'}, new[] {'7', '1', '3', '9', '2', '4', '8', '5', '6'}, new[] {'9', '6', '1', '5', '3', '7', '2', '8', '4'}, new[] {'2', '8', '7', '4', '1', '9', '6', '3', '5'}, new[] {'3', '4', '5', '2', '8', '6', '1', '7', '9'}};

            SolveSudoku(board);

            for (int i = 0; i < 9; ++i)
            {
                if (!board[i].SequenceEqual(expected[i]))
                    return false;
            }

            return true;
        }

        public void SolveSudoku(char[][] board)
        {
            SolveSudokuRec(board, 0, 0);
        }

        public bool SolveSudokuRec(char[][] board, int x, int y)
        {
            if (x == 9)
                return true;
            var nextX = x + (y + 1) / 9;
            var nextY = (y + 1) % 9;
            if (board[x][y] != '.')
                return SolveSudokuRec(board, nextX, nextY);
            for (int i = 0; i < 9; ++i)
            {
                board[x][y] = (char)('1' + i);
                if (Validate(board, x, y) && SolveSudokuRec(board, nextX, nextY))
                    return true;
            }

            board[x][y] = '.';
            return false;
        }

        private bool Validate(char[][] board, int x, int y)
        {
            var n = board[x][y];
            for (int i = 0; i < 9; ++i)
            {
                if ((i != x && board[i][y] == n)
                    || (i != y && board[x][i] == n)
                    || (((x / 3) * 3 + i / 3 != x || (y / 3) * 3 + i % 3 != y) && board[(x / 3) * 3 + i / 3][(y / 3) * 3 + i % 3] == n))
                    return false;
            }

            return true;
        }
    }
}

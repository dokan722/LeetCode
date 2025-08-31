#include "problem_37.h"

bool problem_37::test() {
    std::vector<std::vector<char>> board {{'5', '3', '.', '.', '7', '.', '.', '.', '.'}, {'6', '.', '.', '1', '9', '5', '.', '.', '.'}, {'.', '9', '8', '.', '.', '.', '.', '6', '.'}, {'8', '.', '.', '.', '6', '.', '.', '.', '3'}, {'4', '.', '.', '8', '.', '3', '.', '.', '1'}, {'7', '.', '.', '.', '2', '.', '.', '.', '6'}, {'.', '6', '.', '.', '.', '.', '2', '8', '.'}, {'.', '.', '.', '4', '1', '9', '.', '.', '5'}, {'.', '.', '.', '.', '8', '.', '.', '7', '9'}};

    std::vector<std::vector<char>> expected {{'5', '3', '4', '6', '7', '8', '9', '1', '2'}, {'6', '7', '2', '1', '9', '5', '3', '4', '8'}, {'1', '9', '8', '3', '4', '2', '5', '6', '7'}, {'8', '5', '9', '7', '6', '1', '4', '2', '3'}, {'4', '2', '6', '8', '5', '3', '7', '9', '1'}, {'7', '1', '3', '9', '2', '4', '8', '5', '6'}, {'9', '6', '1', '5', '3', '7', '2', '8', '4'}, {'2', '8', '7', '4', '1', '9', '6', '3', '5'}, {'3', '4', '5', '2', '8', '6', '1', '7', '9'}};

    solveSudoku(board);

    return board == expected;
}

void problem_37::solveSudoku(std::vector<std::vector<char>> &board) {
    solveSudokuRec(board, 0, 0);
}

bool problem_37::solveSudokuRec(std::vector<std::vector<char>> &board, int x, int y) {
    if (x == 9)
        return true;
    int nextX = x + (y + 1) / 9;
    int nextY = (y + 1) % 9;
    if (board[x][y] != '.')
        return solveSudokuRec(board, nextX, nextY);
    for (int i = 0; i < 9; ++i)
    {
        board[x][y] = (char)('1' + i);
        if (validate(board, x, y) && solveSudokuRec(board, nextX, nextY))
            return true;
    }

    board[x][y] = '.';
    return false;
}

bool problem_37::validate(std::vector<std::vector<char>> &board, int x, int y) {
    auto n = board[x][y];
    for (int i = 0; i < 9; ++i)
    {
        if ((i != x && board[i][y] == n)
            || (i != y && board[x][i] == n)
            || (((x / 3) * 3 + i / 3 != x || (y / 3) * 3 + i % 3 != y) && board[(x / 3) * 3 + i / 3][(y / 3) * 3 + i % 3] == n))
            return false;
    }

    return true;
}

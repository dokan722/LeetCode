#include "problem_36.h"

#include <unordered_set>

bool problem_36::test() {
    std::vector<std::vector<char>> board
    {
        { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
        { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
        { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
        { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
        { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
        { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
        { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
        { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
        { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
    };

    auto expected = true;

    auto result = isValidSudoku(board);

    return expected == result;
}

bool problem_36::isValidSudoku(std::vector<std::vector<char>> &board) {
    for (int i = 0; i < 9; i++)
    {
        std::unordered_set<char> rowNums;
        std::unordered_set<char> colNums;
        for (int j = 0; j < 9; j++)
        {
            if (board[i][j] != '.')
            {
                if (rowNums.contains(board[i][j]))
                    return false;
                rowNums.insert(board[i][j]);
            }
            if (board[j][i] != '.')
            {
                if (colNums.contains(board[j][i]))
                    return false;
                colNums.insert(board[j][i]);
            }
        }
    }

    for (int i = 0; i < 3; ++i)
    {
        for (int j = 0; j < 3; j++)
        {
            std::unordered_set<char> partNums;
            int row = i * 3;
            int col = j * 3;
            for (int k = 0; k < 3; ++k)
            {
                for (int l = 0; l < 3; ++l)
                {
                    if (board[row + k][col + l] != '.')
                    {
                        if (partNums.contains(board[row + k][col + l]))
                            return false;
                        partNums.insert(board[row + k][col + l]);
                    }
                }
            }
        }
    }

    return true;
}

from typing import List

from .problem import Problem


class Problem36(Problem):
    def test(self) -> bool:
        board = [['5', '3', '.', '.', '7', '.', '.', '.', '.'],
        ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
        ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
        ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
        ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
        ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
        ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
        ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
        ['.', '.', '.', '.', '8', '.', '.', '7', '9']]

        expected = True

        result = self.isValidSudoku(board)

        return expected == result

    def isValidSudoku(self, board: List[List[str]]) -> bool:
        for i in range(9):
            rowNums = set()
            colNums = set()
            for j in range(9):
                if board[i][j] != '.':
                    if board[i][j] in rowNums:
                        return False
                rowNums.add(board[i][j])

                if board[j][i] != '.':
                    if board[j][i] in colNums:
                        return False
                colNums.add(board[j][i])

        for i in range(3):
            for j in range(3):
                partNums = set()
                row = i * 3
                col = j * 3
                for k in range(3):
                    for l in range(3):
                        if board[row + k][col + l] != '.':
                            if board[row + k][col + l] in partNums:
                                return False
                        partNums.add(board[row + k][col + l])

        return True
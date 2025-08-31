from typing import List

from .problem import Problem


class Problem37(Problem):
    def test(self) -> bool:
        board = [["5", "3", ".", ".", "7", ".", ".", ".", "."], ["6", ".", ".", "1", "9", "5", ".", ".", "."],
                 [".", "9", "8", ".", ".", ".", ".", "6", "."], ["8", ".", ".", ".", "6", ".", ".", ".", "3"],
                 ["4", ".", ".", "8", ".", "3", ".", ".", "1"], ["7", ".", ".", ".", "2", ".", ".", ".", "6"],
                 [".", "6", ".", ".", ".", ".", "2", "8", "."], [".", ".", ".", "4", "1", "9", ".", ".", "5"],
                 [".", ".", ".", ".", "8", ".", ".", "7", "9"]]
        expected = [["5","3","4","6","7","8","9","1","2"],["6","7","2","1","9","5","3","4","8"],["1","9","8","3","4","2","5","6","7"],["8","5","9","7","6","1","4","2","3"],["4","2","6","8","5","3","7","9","1"],["7","1","3","9","2","4","8","5","6"],["9","6","1","5","3","7","2","8","4"],["2","8","7","4","1","9","6","3","5"],["3","4","5","2","8","6","1","7","9"]]

        self.solveSudoku(board)

        return expected == board

    def solveSudoku(self, board: List[List[str]]) -> None:
        self.solveSudokuRec(board, 0, 0)

    def solveSudokuRec(self, board: List[List[str]], x: int, y: int) -> bool:
        if x == 9:
            return True
        nextX = x + (y + 1) // 9
        nextY = (y + 1) % 9
        if board[x][y] != '.':
            return self.solveSudokuRec(board, nextX, nextY)
        for i in range(9):
            board[x][y] = chr(ord('1') + i)
            if self.validate(board, x, y) and self.solveSudokuRec(board, nextX, nextY):
                return True

        board[x][y] = '.'
        return False

    def validate(self, board: List[List[str]], x: int, y: int) -> bool:
        n = board[x][y]
        for i in range(9):
            if ((i != x and board[i][y] == n)
                or (i != y and board[x][i] == n)
                or (((x // 3) * 3 + i // 3 != x or (y // 3) * 3 + i % 3 != y)
                    and board[(x // 3) * 3 + i // 3][(y // 3) * 3 + i % 3] == n)):
                return False

        return True

from typing import List, Dict

from .problem import Problem


class Problem1277(Problem):
    def test(self) -> bool:
        matrix = [[0, 1, 1, 1], [1, 1, 1, 1], [0, 1, 1, 1]]

        expected = 15

        result = self.countSquares(matrix)

        print(result)

        return expected == result

    def countSquares(self, matrix: List[List[int]]) -> int:
        n = len(matrix)
        m = len(matrix[0])
        endingSquares = []
        for i in range(n):
            endingSquares.append([0] * m)

        result = 0
        for i in range(n):
            for j in range(m):
                if matrix[i][j] == 0:
                    endingSquares[i][j] = 0
                else:
                    if i > 0 and j > 0 and matrix[i][j - 1] == 1 and matrix[i - 1][j] == 1 and matrix[i - 1][j - 1] == 1:
                        endingSquares[i][j] = 1 + min(min(endingSquares[i][j - 1], endingSquares[i - 1][j]), endingSquares[i - 1][j - 1])
                    else:
                        endingSquares[i][j] = 1
                    result += endingSquares[i][j]


        return result
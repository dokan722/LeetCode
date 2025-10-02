from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem48(Problem):
    def test(self) -> bool:
        matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]

        expected = [[7, 4, 1], [8, 5, 2], [9, 6, 3]]

        self.rotate(matrix)

        print2DArray(matrix)

        return expected == matrix

    def rotate(self, matrix: List[List[int]]) -> None:
        n = len(matrix)
        for i in range(n):
            for j in range(i, n - 1 - i):
                tmp = matrix[i][j]
                matrix[i][j] = matrix[n - 1 - j][i]
                matrix[n - 1 - j][i] = matrix[n - 1 - i][n - 1 - j]
                matrix[n - 1 - i][n - 1 - j] = matrix[j][n - 1 - i]
                matrix[j][n - 1 - i] = tmp
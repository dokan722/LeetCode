import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class NumMatrix:
    def __init__(self, matrix: List[List[int]]):
        n = len(matrix)
        m = len(matrix[0])
        self.prefs = []
        for i in range(n):
            self.prefs.append([])
            for j in range(m):
                left = self.prefs[i][j - 1] if j > 0 else 0
                up = self.prefs[i - 1][j] if i > 0 else 0
                extra = self.prefs[i - 1][j - 1] if i > 0 and j > 0 else 0
                self.prefs[i].append(matrix[i][j] + left + up - extra)

    def sumRegion(self, row1: int, col1: int, row2: int, col2: int) -> int:
        left = self.prefs[row2][col1 - 1] if col1 > 0 else 0
        up = self.prefs[row1 - 1][col2] if row1 > 0 else 0
        extra = self.prefs[row1 - 1][col1 - 1] if col1 > 0 and row1 > 0 else 0
        return self.prefs[row2][col2] - left - up + extra

class Problem304(Problem):
    def test(self) -> bool:
        numMatrix = NumMatrix([[3, 0, 1, 4, 2], [5, 6, 3, 2, 1], [1, 2, 0, 1, 5], [4, 1, 0, 1, 7], [1, 0, 3, 0, 5]])
        if numMatrix.sumRegion(2, 1, 4, 3) != 8:
            return False
        if numMatrix.sumRegion(1, 1, 2, 2) != 11:
            return False
        if numMatrix.sumRegion(1, 2, 2, 4) != 12:
            return False

        return True
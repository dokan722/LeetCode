import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem892(Problem):
    def test(self) -> bool:
        grid = [[1, 1, 1], [1, 0, 1], [1, 1, 1]]

        expected = 32

        result = self.surfaceArea(grid)

        print(result)

        return result == expected

    def surfaceArea(self, grid: List[List[int]]) -> int:
        result = 0
        n = len(grid)
        for i in range(n):
            for j in range(n):
                up = grid[i][j] if i == 0 else max(0, grid[i][j] - grid[i - 1][j])
                down = grid[i][j] if i == n - 1 else max(0, grid[i][j] - grid[i + 1][j])
                left = grid[i][j] if  j == 0 else max(0, grid[i][j] - grid[i][j - 1])
                right = grid[i][j] if j == n - 1 else max(0, grid[i][j] - grid[i][j + 1])
                rest = 0 if grid[i][j] == 0 else 2
                result += up + down + left + right + rest

        return result
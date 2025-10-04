import heapq
from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2428(Problem):
    def test(self) -> bool:
        grid = [[6, 2, 1, 3], [4, 2, 1, 5], [9, 2, 8, 7], [4, 1, 2, 9]]

        expected = 30

        result = self.maxSum(grid)

        print(result)

        return expected == result

    def maxSum(self, grid: List[List[int]]) -> int:
        n = len(grid)
        m = len(grid[0])
        result = 0

        for i in range(1, n - 1):
            for j in range(1, m - 1):
                result = max(result, grid[i - 1][j - 1] + grid[i - 1][j] + grid[i - 1][j + 1] + grid[i][j] + grid[i + 1][j - 1] + grid[i + 1][j] + grid[i + 1][j + 1])

        return result
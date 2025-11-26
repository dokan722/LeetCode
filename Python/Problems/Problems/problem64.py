import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem64(Problem):
    def test(self) -> bool:
        grid = [[1,3,1],[1,5,1],[4,2,1]]

        expected = 7

        result = self.minPathSum(grid)

        print(result)

        return result == expected

    def minPathSum(self, grid: List[List[int]]) -> int:
        n = len(grid)
        m = len(grid[0])
        dp = []
        for i in range(n):
            dp.append([0] * m)
        dp[0][0] = grid[0][0]
        j = 1
        for i in range(n):
            while j < n:
                dp[i][j] = min(dp[i - 1][j] if i > 0 else sys.maxsize, dp[i][j - 1] if j > 0 else sys.maxsize) + grid[i][j]
                j += 1
            j = 0

        return dp[n - 1][m - 1]
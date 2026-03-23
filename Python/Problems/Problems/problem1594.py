import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1594(Problem):
    def test(self) -> bool:
        grid = [[1, -2, 1], [1, -2, 1], [3, -4, 1]]

        expected = 8

        result = self.maxProductPath(grid)

        print(result)

        return result == expected

    def maxProductPath(self, grid: List[List[int]]) -> int:
        n = len(grid)
        m = len(grid[0])
        mod = 1000000007
        dp = [[[0 , 0] for _ in range(m)] for _ in range(n)]
        for i in range(n):
            for j in range(m):
                if i == 0 and j == 0:
                    dp[i][j] = [grid[i][j], grid[i][j]]
                    continue
                up = dp[i - 1][j] if i > 0 else (-mod, mod)
                left = dp[i][j - 1] if j > 0 else (-mod, mod)
                if grid[i][j] >= 0:
                    dp[i][j] = [max(grid[i][j] * up[0], grid[i][j] * left[0]), min(grid[i][j] * up[1], grid[i][j] * left[1])]
                else:
                    dp[i][j] = [max(grid[i][j] * up[1], grid[i][j] * left[1]), min(grid[i][j] * up[0], grid[i][j] * left[0])]


        return dp[n - 1][m - 1][0] % mod if dp[n - 1][m - 1][0] >= 0 else -1
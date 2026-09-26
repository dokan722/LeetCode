import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3393(Problem):
    def test(self) -> bool:
        grid = [[2, 1, 5], [7, 10, 0], [12, 6, 4]]
        k = 11

        expected = 3

        result = self.countPathsWithXorValue(grid, k)

        print(result)

        return result == expected

    def countPathsWithXorValue(self, grid: List[List[int]], k: int) -> int:
        n = len(grid)
        m = len(grid[0])
        mod = 1000000007
        limit = 16
        dp = [[[0 for _ in range(limit)] for _ in range(m)] for _ in range(n)]
        dp[0][0][grid[0][0]] = 1
        for i in range(n):
            for j in range(m):
                for l in range(limit):
                    next = l ^ grid[i][j]
                    up = dp[i - 1][j][l] if i > 0 else 0
                    left = dp[i][j - 1][l] if j > 0 else 0
                    dp[i][j][next] = (dp[i][j][next] + up + left) % mod

        return dp[n - 1][m - 1][k]
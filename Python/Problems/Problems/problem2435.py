import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2435(Problem):
    def test(self) -> bool:
        grid = [[5,2,4],[3,0,5],[0,7,2]]
        k = 3

        expected = 2

        result = self.numberOfPaths(grid, k)

        print(result)

        return result == expected

    def numberOfPaths(self, grid: List[List[int]], k: int) -> int:
        n = len(grid)
        m = len(grid[0])
        mod = 1000000007
        dp = []
        for i in range(n):
            dp.append([])
            for j in range(m):
                dp[i].append([0] * k)

        dp[0][0][grid[0][0] % k] = 1

        for i in range(n):
            for j in range(m):
                for l in range(k):
                    dp[i][j][(l + grid[i][j]) %k] += ((dp[i - 1][j][l] if i > 0 else 0) + (dp[i][j - 1][l] if j > 0 else 0)) % mod

        return dp[n - 1][m - 1][0]
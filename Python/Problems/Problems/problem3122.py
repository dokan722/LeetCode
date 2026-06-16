import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3122(Problem):
    def test(self) -> bool:
        grid = [[1, 0, 2], [1, 0, 2]]

        expected = 0

        result = self.minimumOperations(grid)

        print(result)

        return result == expected

    def minimumOperations(self, grid: List[List[int]]) -> int:
        cap = 10
        n = len(grid)
        m = len(grid[0])
        dp = [0] * cap
        for i in range(m):
            counts = [0] * cap
            for j in range(n):
                counts[grid[j][i]] += 1
            next = [0] * cap
            for j in range(cap):
                best = sys.maxsize
                for k in range(cap):
                    if k != j:
                        best = min(best, dp[k] + (n - counts[k]))
                next[j] = best
            dp = next
        result = sys.maxsize
        for i in range(cap):
            result = min(dp[i], result)
        return result
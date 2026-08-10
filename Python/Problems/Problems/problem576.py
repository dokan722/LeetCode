import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem576(Problem):
    def test(self) -> bool:
        m = 2
        n = 2
        maxMove = 2
        startRow = 0
        startColumn = 0

        expected = 6

        result = self.findPaths(m, n, maxMove, startRow, startColumn)

        print(result)

        return result == expected

    def findPaths(self, m: int, n: int, maxMove: int, startRow: int, startColumn: int) -> int:
        cur = [[0 for _ in range(n)] for _ in range(m)]
        cur[startRow][startColumn] = 1
        result = 0
        mod = 1000000007
        for i in range(maxMove):
            for j in range(m):
                result = (result + cur[j][0] + cur[j][n - 1]) % mod
            for j in range(n):
                result = (result + cur[0][j] + cur[m - 1][j]) % mod
            next = [[0 for _ in range(n)] for _ in range(m)]
            for j in range(m):
                for k in range(n):
                    up = cur[j - 1][k] if j > 0 else 0
                    down = cur[j + 1][k] if j < m - 1 else 0
                    left = cur[j][k - 1] if k > 0 else 0
                    right = cur[j][k + 1] if k < n - 1 else 0
                    next[j][k] = (up + down + left + right) % mod
            cur = next

        return result
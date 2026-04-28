import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2033(Problem):
    def test(self) -> bool:
        grid = [[2, 4], [6, 8]]
        x = 2

        expected = 4

        result = self.minOperations(grid, x)

        print(result)

        return result == expected

    def minOperations(self, grid: List[List[int]], x: int) -> int:
        n = len(grid)
        m = len(grid[0])
        exp = grid[0][0] % x
        freqs = [0] * (100001 // x + 1)
        for i in range(n):
            for j in range(m):
                if grid[i][j] % x != exp:
                    return -1
                freqs[grid[i][j] // x] += 1

        mid = (m * n + 1) // 2
        count = 0
        median = 0
        for i in range(len(freqs)):
            count += freqs[i]
            if count >= mid:
                median = i
                break

        result = 0
        for i in range(len(freqs)):
            result += abs(i - median) * freqs[i]

        return result
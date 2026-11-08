import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1267(Problem):
    def test(self) -> bool:
        grid = [[1, 0], [1, 1]]

        expected = 3

        result = self.countServers(grid)

        print(result)

        return result == expected

    def countServers(self, grid: list[list[int]]) -> int:
        n = len(grid)
        m = len(grid[0])
        rows = [0] * n
        cols = [0] * m
        for i in range(n):
            for j in range(m):
                if grid[i][j] == 1:
                    rows[i] += 1
                    cols[j] += 1
        result = 0
        for i in range(n):
            for j in range(m):
                if (grid[i][j] == 1 and (rows[i] > 1 or cols[j] > 1)):
                    result += 1

        return result
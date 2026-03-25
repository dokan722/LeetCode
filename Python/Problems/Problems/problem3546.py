import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3546(Problem):
    def test(self) -> bool:
        grid = [[1, 4], [2, 3]]

        expected = True

        result = self.canPartitionGrid(grid)

        return result == expected

    def canPartitionGrid(self, grid: List[List[int]]) -> bool:
        n = len(grid)
        m = len(grid[0])
        s = 0
        for i in range(n):
            for j in range(m):
                s += grid[i][j]
        if s % 2 != 0:
            return False
        req = s // 2
        hor = 0
        ver = 0
        for i in range(n):
            for j in range(m):
                hor += grid[i][j]
            if hor == req:
                return True
        for i in range(m):
            for j in range(n):
                ver += grid[j][i]
            if ver == req:
                return True

        return False
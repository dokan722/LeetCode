import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1260(Problem):
    def test(self) -> bool:
        grid = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
        k = 1

        expected = [[9, 1, 2], [3, 4, 5], [6, 7, 8]]

        result = self.shiftGrid(grid, k)

        print2DArray(result)

        return expected == result

    def shiftGrid(self, grid: List[List[int]], k: int) -> List[List[int]]:
        if k == 0:
            return grid
        n = len(grid)
        m = len(grid[0])
        t = n * m
        k %= t
        self.revGrid(grid, 0, t - 1, m)
        self.revGrid(grid, 0, k - 1, m)
        self.revGrid(grid, k, t - 1, m)

        return grid

    def revGrid(self, grid: List[List[int]], l: int, r: int, m: int) -> None:
        while l < r:
            lx = l // m
            ly = l % m
            rx = r // m
            ry = r % m
            (grid[lx][ly], grid[rx][ry]) = (grid[rx][ry], grid[lx][ly])
            l += 1
            r -= 1
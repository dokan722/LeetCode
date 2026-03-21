import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3643(Problem):
    def test(self) -> bool:
        grid = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16]]
        x = 1
        y = 0
        k = 3

        expected = [[1, 2, 3, 4], [13, 14, 15, 8], [9, 10, 11, 12], [5, 6, 7, 16]]

        result = self.reverseSubmatrix(grid, x, y, k)

        print2DArray(result)

        return expected == result

    def reverseSubmatrix(self, grid: List[List[int]], x: int, y: int, k: int) -> List[List[int]]:
        swaps = k // 2
        for i in range(swaps):
            up = x + i
            down = x + k - i - 1
            for j in range(k):
                grid[down][y + j], grid[up][y + j] = grid[up][y + j], grid[down][y + j]

        return grid
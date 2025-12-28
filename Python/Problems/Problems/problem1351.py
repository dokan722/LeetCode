import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1351(Problem):
    def test(self) -> bool:
        grid = [[4, 3, 2, -1], [3, 2, 1, -1], [1, 1, -1, -2], [-1, -1, -2, -3]]

        expected = 8

        result = self.countNegatives(grid)

        print(result)

        return result == expected

    def countNegatives(self, grid: List[List[int]]) -> int:
        n = len(grid)
        m = len(grid[0])
        i = n - 1
        j = 0
        result = 0
        while j < m:
            if grid[i][j] < 0:
                result += j
                j -= 1
                i -= 1
                if i < 0:
                    break
            j += 1
        result = n * m - (result + (i + 1) * m)

        return result
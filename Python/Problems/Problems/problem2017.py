import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2017(Problem):
    def test(self) -> bool:
        grid = [[2, 5, 4], [1, 5, 1]]

        expected = 4

        result = self.gridGame(grid)

        print(result)

        return result == expected

    def gridGame(self, grid: List[List[int]]) -> int:
        n = len(grid[0])
        sums = [sum(grid[0]), sum(grid[1])]

        result = sums[0] - grid[0][0]
        prefs = [grid[0][0], 0]
        for i in range(1, n):
            prefs[0] += grid[0][i]
            prefs[1] += grid[1][i - 1]
            result = min(result, max(sums[0] - prefs[0], prefs[1]))

        return result
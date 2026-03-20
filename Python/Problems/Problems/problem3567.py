import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3567(Problem):
    def test(self) -> bool:
        grid = [[1, 8], [3, -2]]
        k = 2

        expected = [[2]]

        result = self.minAbsDiff(grid, k)

        print1DArray(result)

        return expected == result

    def minAbsDiff(self, grid: List[List[int]], k: int) -> List[List[int]]:
        m = len(grid)
        n = len(grid[0])
        result = [[0] * (n - k + 1) for _ in range(m - k + 1)]

        for i in range(m - k + 1):
            for j in range(n - k + 1):
                elems = []
                for l in range(i, i + k):
                    for o in range(j, j + k):
                        elems.append(grid[l][o])
                smallest = sys.maxsize
                elems.sort()
                for t in range(1, len(elems)):
                    if elems[t] == elems[t - 1]:
                        continue
                    smallest = min(smallest, elems[t] - elems[t - 1])

                result[i][j] =  0 if smallest == sys.maxsize else smallest

        return result
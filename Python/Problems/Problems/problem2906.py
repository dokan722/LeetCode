import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2906(Problem):
    def test(self) -> bool:
        grid = [[1, 2], [3, 4]]

        expected = [[24, 12], [8, 6]]

        result = self.constructProductMatrix(grid)

        print2DArray(result)

        return expected == result

    def constructProductMatrix(self, grid: List[List[int]]) -> List[List[int]]:
        n = len(grid)
        m = len(grid[0])
        l = n * m
        mod = 12345
        prefs = [0] * l
        sufs = [0] * l
        prefs[0] = grid[0][0] % mod
        sufs[l - 1] = grid[n - 1][m - 1] % mod
        for i in range(1, l):
            prefs[i] = (grid[i // m][i % m] % mod) * (prefs[i - 1] % mod) % mod
            sufs[l - i - 1] = (grid[n - 1 - (i // m)][m - 1 - (i % m)] % mod) * (sufs[l - i] % mod) % mod

        result = []
        for i in range(n):
            result.append([0] * m)
            for j in range(m):
                if i == 0 and j == 0:
                    result[i][j] = sufs[1]
                    continue
                elif i == n - 1 and j == m - 1:
                    result[i][j] = prefs[l - 2]
                    continue
                result[i][j] = prefs[i * m + j - 1] * sufs[i * m + j + 1] % mod

        return result
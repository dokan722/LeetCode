import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3212(Problem):
    def test(self) -> bool:
        grid = [['X', 'Y', '.'], ['Y', '.', '.']]

        expected = 3

        result = self.numberOfSubmatrices(grid)

        print(result)

        return result == expected

    def numberOfSubmatrices(self, grid: List[List[str]]) -> int:
        n = len(grid)
        m = len(grid[0])
        xs = [[0 for _ in range(m)] for _ in range(n)]
        ys = [[0 for _ in range(m)] for _ in range(n)]

        result = 0
        for i in range(n):
            for j in range(m):
                upx = xs[i - 1][j] if i > 0 else 0
                leftx = xs[i][j - 1] if j > 0 else 0
                lastx = xs[i - 1][j - 1] if i > 0 and j > 0 else 0
                xs[i][j] = upx + leftx - lastx + (1 if grid[i][j] == 'X' else 0)
                upy = ys[i - 1][j] if i > 0 else 0
                lefty = ys[i][j - 1] if j > 0 else 0
                lasty = ys[i - 1][j - 1] if i > 0 and j > 0 else 0
                ys[i][j] = upy + lefty - lasty + (1 if grid[i][j] == 'Y' else 0)
                if xs[i][j] != 0 and xs[i][j] == ys[i][j]:
                    result += 1


        return result
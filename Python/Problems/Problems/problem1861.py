import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1861(Problem):
    def test(self) -> bool:
        boxGrid = [['#', '.', '#']]

        expected = [['.'], ['#'], ['#']]

        result = self.rotateTheBox(boxGrid)

        print2DArray(result)

        return expected == result

    def rotateTheBox(self, boxGrid: List[List[str]]) -> List[List[str]]:
        n = len(boxGrid)
        m = len(boxGrid[0])
        result = [['.' for _ in range(n)] for _ in range(m)]
        for i in range(n):
            cur = m - 1
            for j in range(m - 1, -1, -1):
                cell = boxGrid[i][j]
                if cell == '#':
                    result[cur][n - 1 - i] = '#'
                    cur -= 1
                elif cell == '*':
                    result[j][n - 1 - i] = '*'
                    cur = j - 1

        return result
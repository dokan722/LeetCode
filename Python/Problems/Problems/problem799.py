import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem799(Problem):
    def test(self) -> bool:
        poured = 100000009
        query_row = 33
        query_glass = 17

        expected = 1.0

        result = self.champagneTower(poured, query_row, query_glass)

        print(result)

        return abs(expected - result) < 1e-5

    def champagneTower(self, poured: int, query_row: int, query_glass: int) -> float:
        row = [poured]
        for i in range(1, query_row + 1):
            currRow = []
            currRow.append(max(0.0, (row[0] - 1) / 2))
            for j in range(1, i):
                currRow.append(max(0.0, (max(0.0, row[j - 1] - 1) + max(0.0, row[j] - 1)) / 2))
            currRow.append(max(0.0, (row[i - 1] - 1) / 2))
            row = currRow

        return min(1.0, row[query_glass])
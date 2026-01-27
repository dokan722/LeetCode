import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3160(Problem):
    def test(self) -> bool:
        limit = 4
        queries = [[1, 4], [2, 5], [1, 3], [3, 4]]

        expected = [1, 2, 2, 3]

        result = self.queryResults(limit, queries)

        print1DArray(result)

        return expected == result

    def queryResults(self, limit: int, queries: List[List[int]]) -> List[int]:
        n = len(queries)
        color = dict()
        colorCounts = dict()
        colorCounts[0] = n + 1
        colors = 0
        result = [0] * n
        for i in range(n):
            oldColor = color[queries[i][0]] if queries[i][0] in color else 0
            newColor = queries[i][1]
            color[queries[i][0]] = newColor
            colorCounts[oldColor] -= 1
            if colorCounts[oldColor] == 0:
                colorCounts.pop(oldColor)
            if newColor not in colorCounts:
                colorCounts[newColor] = 0
            colorCounts[newColor] += 1
            result[i] = len(colorCounts) - 1

        return result
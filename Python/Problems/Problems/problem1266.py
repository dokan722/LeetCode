import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1266(Problem):
    def test(self) -> bool:
        points = [[1, 1], [3, 4], [-1, 0]]

        expected = 7

        result = self.minTimeToVisitAllPoints(points)

        print(result)

        return result == expected

    def minTimeToVisitAllPoints(self, points: List[List[int]]) -> int:
        n = len(points)

        result = 0
        for i in range(1, n):
            result += max(abs(points[i][0] - points[i - 1][0]), abs(points[i][1] - points[i - 1][1]))

        return result
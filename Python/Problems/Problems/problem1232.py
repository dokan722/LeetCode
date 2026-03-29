import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1232(Problem):
    def test(self) -> bool:
        coordinates = [[1, 2], [2, 3], [3, 4], [4, 5], [5, 6], [6, 7]]

        expected = True

        result = self.checkStraightLine(coordinates)

        return result == expected

    def checkStraightLine(self, coordinates: List[List[int]]) -> bool:
        n = len(coordinates)
        x1 = coordinates[0][0]
        x2 = coordinates[1][0]
        y1 = coordinates[0][1]
        y2 = coordinates[1][1]
        for i in range(2, n):
            x = coordinates[i][0]
            y = coordinates[i][1]
            if (y - y2) * (x2 - x1) != (y2 - y1) * (x - x2):
                return False

        return True
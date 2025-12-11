import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3531(Problem):
    def test(self) -> bool:
        n = 3
        buildings = [[1, 2], [2, 2], [3, 2], [2, 1], [2, 3]]

        expected = 1

        result = self.countCoveredBuildings(n, buildings)

        print(result)

        return expected == result

    def countCoveredBuildings(self, n: int, buildings: List[List[int]]) -> int:
        maxX = [0] * (n + 1)
        maxY = [0] * (n + 1)
        minX = [n + 1] * (n + 1) 
        minY = [n + 1] * (n + 1) 

        for b in buildings:
            maxX[b[1]] = max(maxX[b[1]], b[0])
            maxY[b[0]] = max(maxY[b[0]], b[1])
            minX[b[1]] = min(minX[b[1]], b[0])
            minY[b[0]] = min(minY[b[0]], b[1])

        result = 0
        for b in buildings:
            if maxX[b[1]] > b[0] > minX[b[1]] and maxY[b[0]] > b[1] > minY[b[0]]:
                result += 1

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3047(Problem):
    def test(self) -> bool:
        bottomLeft = [[1, 1], [2, 2], [3, 1]]
        topRight = [[3, 3], [4, 4], [6, 6]]

        expected = 1

        result = self.largestSquareArea(bottomLeft, topRight)

        print(result)

        return result == expected

    def largestSquareArea(self, bottomLeft: List[List[int]], topRight: List[List[int]]) -> int:
        n = len(bottomLeft)
        result = 0
        for i in range(n):
            for j in range(i + 1, n):
                bottomBound = max(bottomLeft[i][1], bottomLeft[j][1])
                topBound = min(topRight[i][1], topRight[j][1])
                leftBound = max(bottomLeft[i][0], bottomLeft[j][0])
                rightBound = min(topRight[i][0], topRight[j][0])
                height = topBound - bottomBound
                width = rightBound - leftBound
                side = min(height, width)
                if side > 0:
                    result = max(result, side * side)

        return result
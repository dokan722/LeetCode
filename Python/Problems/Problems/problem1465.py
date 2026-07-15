import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1465(Problem):
    def test(self) -> bool:
        h = 5
        w = 4
        horizontalCuts = [1, 2, 4]
        verticalCuts = [1, 3]

        expected = 4

        result = self.maxArea(h, w, horizontalCuts, verticalCuts)

        print(result)

        return result == expected

    def maxArea(self, h: int, w: int, horizontalCuts: List[int], verticalCuts: List[int]) -> int:
        n = len(horizontalCuts)
        m = len(verticalCuts)
        horizontalCuts.sort()
        verticalCuts.sort()
        maxH = horizontalCuts[0]
        for i in range(1, n):
            maxH = max(maxH, horizontalCuts[i] - horizontalCuts[i - 1])
        maxH = max(maxH, h - horizontalCuts[n - 1])
        maxW = verticalCuts[0]
        for i in range(1, m):
            maxW = max(maxW, verticalCuts[i] - verticalCuts[i - 1])
        maxW = max(maxW, w - verticalCuts[m - 1])

        return maxH * maxW % 1000000007
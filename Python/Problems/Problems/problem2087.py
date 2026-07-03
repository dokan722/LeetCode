import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2087(Problem):
    def test(self) -> bool:
        startPos = [1, 0]
        homePos = [2, 3]
        rowCosts = [5, 4, 3]
        colCosts = [8, 2, 6, 7]

        expected = 18

        result = self.minCost(startPos, homePos, rowCosts, colCosts)

        print(result)

        return result == expected

    def minCost(self, startPos: List[int], homePos: List[int], rowCosts: List[int], colCosts: List[int]) -> int:
        result = rowCosts[homePos[0]] + colCosts[homePos[1]] - rowCosts[startPos[0]] - colCosts[startPos[1]]
        it = 1 if startPos[0] <= homePos[0] else -1
        for i in range(startPos[0], homePos[0], it):
            result += rowCosts[i]
        it = 1 if startPos[1] <= homePos[1] else -1
        for i in range(startPos[1], homePos[1], it):
            result += colCosts[i]
        return result
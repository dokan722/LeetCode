import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem447(Problem):
    def test(self) -> bool:
        points = [[0, 0], [1, 0], [2, 0]]

        expected = 2

        result = self.numberOfBoomerangs(points)

        print(result)

        return result == expected

    def numberOfBoomerangs(self, points: List[List[int]]) -> int:
        n = len(points)
        dists = dict()
        result = 0
        for i in range(n):
            for j in range(n):
                x = points[i][0] - points[j][0]
                y = points[i][1] - points[j][1]
                dist = x * x + y * y
                if dist in dists:
                    result += 2 * dists[dist]
                    dists[dist] += 1
                else:
                    dists[dist] = 1
            dists.clear()

        return result
import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3625(Problem):
    def test(self) -> bool:
        points = [[-3, 2], [3, 0], [2, 3], [3, 2], [2, -3]]

        expected = 2

        result = self.countTrapezoids(points)

        print(result)

        return result == expected

    def countTrapezoids(self, points: List[List[int]]) -> int:
        n = len(points)
        trap = dict()
        par = dict()
        for i in range(n):
            x1 = points[i][0]
            y1 = points[i][1]
            for j in range(i + 1, n):
                x2 = points[j][0]
                y2 = points[j][1]
                dx = x1 - x2
                dy = y1 - y2
                if x1 == x2:
                    a = sys.maxsize
                    b = x1
                else:
                    a = (y2 - y1) / (x2 - x1)
                    b = (y1 * dx - x1 * dy) / dx

                mid = (x1 + x2) * 10000.0 + (y1 + y2)
                if a not in trap:
                    trap[a] = dict()
                if mid not in par:
                    par[mid] = dict()
                if b not in trap[a]:
                    trap[a][b] = 1
                else:
                    trap[a][b] += 1
                if a not in par[mid]:
                    par[mid][a] = 1
                else:
                    par[mid][a] += 1

        result = 0
        for t in trap.values():
            curr = 0
            for count in t.values():
                result += curr * count
                curr += count

        for p in par.values():
            curr = 0
            for count in p.values():
                result -= curr * count
                curr += count

        return result
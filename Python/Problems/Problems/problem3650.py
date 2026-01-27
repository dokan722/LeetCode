import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3650(Problem):
    def test(self) -> bool:
        n = 4
        edges = [[0, 1, 3], [3, 1, 1], [2, 3, 4], [0, 2, 2]]

        expected = 5

        result = self.minCost(n, edges)

        print(result)

        return result == expected

    def minCost(self, n: int, edges: List[List[int]]) -> int:
        queue = []
        neighbours = [[] for _ in range(n)]
        dists = [0] * n
        for i in range(1, n):
            dists[i] = sys.maxsize

        for edge in edges:
            neighbours[edge[0]].append([edge[1], edge[2]])
            neighbours[edge[1]].append([edge[0], 2 * edge[2]])

        heapq.heappush(queue, [0, 0])
        while queue:
            top = heapq.heappop(queue)
            cur = top[0]
            curDist = top[1]
            for neighbour in neighbours[cur]:
                newDist = curDist + neighbour[1]
                if (newDist < dists[neighbour[0]]):
                    dists[neighbour[0]] = newDist
                    heapq.heappush(queue, [neighbour[0], newDist])

        return - 1 if dists[n - 1] == sys.maxsize else dists[n - 1]
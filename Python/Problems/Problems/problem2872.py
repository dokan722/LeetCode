import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2872(Problem):
    def __init__(self):
        self.count = 0

    def test(self) -> bool:
        n = 5
        edges = [[0, 2], [1, 2], [1, 3], [2, 4]]
        values = [1, 8, 1, 4, 4]
        k = 6

        expected = 2

        result = self.maxKDivisibleComponents(n, edges, values, k)

        print(result)

        return result == expected

    def maxKDivisibleComponents(self, n: int, edges: List[List[int]], values: List[int], k: int) -> int:
        graph = [[] for _ in range(n)]
        for edge in edges:
            graph[edge[0]].append(edge[1])
            graph[edge[1]].append(edge[0])

        self.dfs(0, -1, graph, values, k)

        return self.count

    def dfs(self, e: int, prev: int, graph: List[List[int]], values: List[int], k: int) -> int:
        sum = values[e]
        for n in graph[e]:
            if n != prev:
                sum += self.dfs(n, e, graph, values, k)
                sum %= k
        if (sum % k == 0):
            self.count += 1

        return sum
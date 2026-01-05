import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2672(Problem):
    def test(self) -> bool:
        n = 4
        queries = [[0, 2], [1, 2], [3, 1], [1, 1], [2, 1]]

        expected = [0, 1, 1, 0, 2]

        result = self.colorTheArray(n, queries)

        print1DArray(result)

        return expected == result

    def colorTheArray(self, n: int, queries: List[List[int]]) -> List[int]:
        m = len(queries)
        curr = 0
        colors = [0] * (n + 2)
        result = []
        for i in range(m):
            query = queries[i]
            id = query[0] + 1
            if colors[id] == query[1]:
                result.append(curr)
                continue
            prevL = 1 if colors[id - 1] != 0 and colors[id] == colors[id - 1] else  0
            currL = 1 if query[1] == colors[id - 1] else 0
            prevR = 1 if colors[id + 1] != 0 and  colors[id] == colors[id + 1] else 0
            currR = 1 if query[1] == colors[id + 1] else 0
            curr += currL + currR - prevL - prevR
            colors[id] = query[1]
            result.append(curr)

        return result
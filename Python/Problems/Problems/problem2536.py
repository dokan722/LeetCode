import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2536(Problem):
    def test(self) -> bool:
        n = 3
        queries = [[1, 1, 2, 2], [0, 0, 1, 1]]

        expected = [[1, 1, 0], [1, 2, 1], [0, 1, 1]]

        result = self.rangeAddQueries(n, queries)

        print2DArray(result)

        return expected == result

    def rangeAddQueries(self, n: int, queries: List[List[int]]) -> List[List[int]]:
        ranges = []
        for i in range(n + 1):
            ranges.append([0] * (n + 1))
        for query in queries:
            ranges[query[0]][query[3] + 1] -= 1
            ranges[query[2] + 1][query[1]] -= 1
            ranges[query[0]][query[1]] += 1
            ranges[query[2] + 1][query[3] + 1] += 1
        result = []
        for i in range(n):
            result.append([0] * (n))
        result[0][0] = ranges[0][0]
        for i in range(1, n):
            result[0][i] = result[0][i - 1] + ranges[0][i]
            result[i][0] = result[i - 1][0] + ranges[i][0]

        for i in range(1, n):
            for j in range(1, n):
                result[i][j] = result[i][j - 1] + result[i - 1][j] + ranges[i][j] - result[i - 1][j - 1]

        return result
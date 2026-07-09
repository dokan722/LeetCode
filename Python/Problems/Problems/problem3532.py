import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3532(Problem):
    def test(self) -> bool:
        n = 2
        nums = [1, 3]
        maxDiff = 1
        queries = [[0, 0], [0, 1]]

        expected = [True, False]

        result = self.pathExistenceQueries(n, nums, maxDiff, queries)

        print1DArray(result)

        return expected == result

    def pathExistenceQueries(self, n: int, nums: List[int], maxDiff: int, queries: List[List[int]]) -> List[bool]:
        clusts = [0]
        cur = 0
        for i in range(1, n):
            if nums[i - 1] + maxDiff < nums[i]:
                cur += 1
            clusts.append(cur)
        m = len(queries)
        result = []
        for i in range(m):
            q = queries[i]
            result.append(clusts[q[0]] == clusts[q[1]])

        return result
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3488(Problem):
    def test(self) -> bool:
        nums = [1, 3, 1, 4, 1, 3, 2]
        queries = [0, 3, 5]

        expected = [2, -1, 3]

        result = self.solveQueries(nums, queries)

        print1DArray(result)

        return expected == result

    def solveQueries(self, nums: List[int], queries: List[int]) -> List[int]:
        n = len(nums)
        m = len(queries)
        result = [0] * m
        dists = [sys.maxsize] * n
        pos = dict()
        for i in range(n):
            if nums[i] not in pos:
                pos[nums[i]] = (i, i)
            else:
                p = pos[nums[i]]
                back = i - p[1]
                front = n - i + p[0]
                pos[nums[i]] = (p[0], i)
                dists[i] = min(back, front)
                dists[p[0]] = min(dists[p[0]], front)
                dists[p[1]] = min(dists[p[1]], back)

        for i in range(m):
            result[i] = -1 if dists[queries[i]] ==sys.maxsize else dists[queries[i]]

        return result